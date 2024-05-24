namespace ContainerVervoer.Classes
{
    public class ContainerShip
    {
        public int LengthInContainers { get; private set; }
        public int WidthInContainers { get; private set; }
        public int MaxShipWeight { get; private set; }
        public int CurrentShipWeight { get; private set; }
        public IEnumerable<ContainerStack> ContainerSpots { get { return containerSpots; } }
        private List<ContainerStack> containerSpots { get; set; } = new();
        public IEnumerable<Container> ContainersOnBay { get { return containersOnBay; } }
        private List<Container> containersOnBay { get; set; } = new();

        public ContainerShip(int length, int width)
        {
            LengthInContainers = length;
            WidthInContainers = width;
            CreateContainerSpots();
            MaxShipWeight = containerSpots.Count * 150;
        }

        public void AddContainerToBay(int weight, bool hasValuable, bool isCooled)
        {
            containersOnBay.Add(new Container(weight, hasValuable, isCooled));
        }

        public void DivideContainersOverShip()
        {
            int currentCooledSpot = 0;
            int lastCooledSpot = 0;
            int currentNormalSpot = WidthInContainers;
            int lastNormalSpot = WidthInContainers;


            SortContainers();

            foreach (Container container in containersOnBay)
            {
                bool containerAdded = false;

                // Resetting Current Variables
                if (currentCooledSpot == WidthInContainers) currentCooledSpot = 0;
                if (currentNormalSpot == containerSpots.Count()) currentNormalSpot = WidthInContainers;

                if (container.HasCooling && !container.HasValuables)
                {
                    while (!containerAdded)
                    {
                        containerAdded = containerSpots[currentCooledSpot].TryAddingContainerToStack(container);

                        lastCooledSpot = currentCooledSpot;
                        currentCooledSpot++;

                        if (containerAdded) continue;
                    }

                    if (!containerAdded)
                        throw new ArgumentException("Container could not be added to any of the cooled spots!");
                    else continue;
                }
                else if (container.HasValuables && !container.HasCooling)
                {
                    while (!containerAdded)
                    {
                        if (IsContainerSurrounded(containerSpots[currentNormalSpot], containerSpots[currentNormalSpot - WidthInContainers]))
                        {
                            if (!IsSurroundingContainerValuable(containerSpots[currentNormalSpot - WidthInContainers]) && container.HasValuables)
                            {
                                containerAdded = containerSpots[currentNormalSpot].TryAddingContainerToStack(container);
                            }
                        }

                        //if (!IsContainerSurrounded(containerSpots[currentNormalSpot], containerSpots[currentNormalSpot - WidthInContainers])
                        //    && !IsSurroundingContainerValuable(containerSpots[currentNormalSpot - WidthInContainers]))
                        //{
                        //    containerAdded = containerSpots[currentNormalSpot].TryAddingContainerToStack(container);
                        //}

                        lastNormalSpot = currentNormalSpot;
                        currentNormalSpot++;

                        if (containerAdded) continue;
                    }

                    if (!containerAdded)
                        throw new ArgumentException("Container could not be added to any of the normal spots!");
                    else continue;
                }
                else if (container.HasCooling && container.HasValuables)
                {
                    while (!containerAdded)
                    {
                        containerAdded = containerSpots[currentCooledSpot].TryAddingContainerToStack(container);
                    }

                    lastCooledSpot = currentCooledSpot;
                    currentCooledSpot++;

                    if (containerAdded) continue;

                    if (!containerAdded)
                        throw new ArgumentException("Container could not be added to any of the normal spots!");
                    else continue;
                }
                else
                {
                    while (!containerAdded)
                    {
                        if (containerSpots[currentNormalSpot].Containers.Count() + 1 == containerSpots[currentNormalSpot - WidthInContainers].Containers.Count())
                        {
                            if (!IsSurroundingContainerValuable(containerSpots[currentNormalSpot - WidthInContainers]))
                            {
                                containerAdded = containerSpots[currentNormalSpot].TryAddingContainerToStack(container);
                            }

                            containerAdded = containerSpots[currentNormalSpot].TryAddingContainerToStack(container);
                        }

                        lastNormalSpot = currentNormalSpot;
                        currentNormalSpot++;

                        if (containerAdded) continue;
                    }

                    if (!containerAdded)
                        throw new ArgumentException("Container could not be added to any of the normal spots!");
                    else continue;
                }
            }
        }

        private void CreateContainerSpots()
        {
            for (int c = 0; c < LengthInContainers; c++)
            {
                for(int r = 0; r < WidthInContainers; r++)
                {
                    containerSpots.Add(new ContainerStack());
                }
            }
        }

        private void SortContainers()
        {
            // TO DO:
            // ORDER containers:
            // 1st: HasCooling - Weight: High -> Low
            // 2nd: Normal - Weight: High -> Low
            // 3th: HasValuables - Weight: High -> Low

            containersOnBay = containersOnBay.OrderByDescending(c => c.HasCooling)
                .ThenBy(c => c.HasValuables).ToList();
        }

        #region Checks
        private bool IsContainerSurrounded(ContainerStack currentStack, ContainerStack surroundingStack)
        {
            bool asd = currentStack.Containers.Count() + 1 >= surroundingStack.Containers.Count();

            return asd;
        }

        private bool IsSurroundingContainerValuable(ContainerStack surroundingStack)
        {
            if (surroundingStack.Containers.Count() != 0)
            {
                return surroundingStack.Containers.Last().HasValuables;
            }
            return false;
        }

        private void CheckShipWeightForSafety()
        {
            IsHalfOfShipWeightUsed();

            int weightLeftSide = CalculateWeightOnSide(this, 0);
            int weightRightSide = CalculateWeightOnSide(this, WidthInContainers - 1);
            bool safeMargin = CalculateMarginOfSides(weightLeftSide, weightRightSide);
        }

        private bool IsHalfOfShipWeightUsed()
        {
            return CurrentShipWeight >= MaxShipWeight / 2;
        }

        public static int CalculateWeightOnSide(ContainerShip ship, int index)
        {
            int totalWeight = 0;

            for (int i = 0; i < ship.containerSpots.Count() / ship.WidthInContainers; i++)
            {
                totalWeight += ship.containerSpots[index].StackWeight;
                index += ship.WidthInContainers;
            }

            return totalWeight;
        }

        public static bool CalculateMarginOfSides(int weightLeftSide, int weightRightSide)
        {
            return weightLeftSide >= weightRightSide * 0.8 && weightRightSide >= weightLeftSide * 0.8;
        }
        #endregion
    }
}
