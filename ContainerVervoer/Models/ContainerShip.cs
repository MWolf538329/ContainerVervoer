using ContainerVervoer.Models;

namespace ContainerVervoer.Classes
{
    public class ContainerShip
    {
        public int LengthInContainers { get; private set; }
        public int WidthInContainers { get; private set; }
        public int MaxShipWeight { get { return LengthInContainers * WidthInContainers * 150; } }
        public int CurrentShipWeight { get { return containerStackRows.Sum(s => s.StackRowWeight); } }
        public IReadOnlyList<ContainerStackRow> ContainerStackRows { get { return containerStackRows; } }
        private List<ContainerStackRow> containerStackRows { get; set; } = new();
        public IReadOnlyList<Container> ContainersOnBay { get { return containersOnBay; } }
        private List<Container> containersOnBay { get; set; } = new();

        public ContainerShip(int length, int width)
        {
            LengthInContainers = length;
            WidthInContainers = width;
            CreateContainerStackRows();
        }

        public void AddContainerToBay(int weight, bool hasValuable, bool isCooled)
        {
            containersOnBay.Add(new Container(weight, hasValuable, isCooled));
        }

        //public void DivideContainersOverShip()
        //{
        //    int currentCooledSpot = 0;
        //    int lastCooledSpot = 0;
        //    int currentNormalSpot = WidthInContainers;
        //    int lastNormalSpot = WidthInContainers;

        //    containersOnBay = SortContainers(containersOnBay);

        //    foreach (Container container in containersOnBay)
        //    {
        //        bool containerAdded = false;

        //        Resetting Current Variables
        //        if (currentCooledSpot == WidthInContainers) currentCooledSpot = 0;
        //        if (currentNormalSpot == containerSpots.Count()) currentNormalSpot = WidthInContainers;

        //        if (container.HasCooling && !container.HasValuables)
        //        {
        //            while (!containerAdded)
        //            {
        //                containerAdded = containerSpots[currentCooledSpot].TryAddingContainerToStack(container);

        //                lastCooledSpot = currentCooledSpot;
        //                currentCooledSpot++;

        //                if (containerAdded) continue;
        //            }

        //            if (!containerAdded)
        //                throw new ArgumentException("Container could not be added to any of the cooled spots!");
        //            else continue;
        //        }
        //        else if (container.HasValuables && !container.HasCooling)
        //        {
        //            while (!containerAdded)
        //            {
        //                if (IsContainerSurrounded(containerSpots[currentNormalSpot], containerSpots[currentNormalSpot - WidthInContainers]))
        //                {
        //                    if (!IsSurroundingContainerValuable(containerSpots[currentNormalSpot - WidthInContainers]) && container.HasValuables)
        //                    {
        //                        containerAdded = containerSpots[currentNormalSpot].TryAddingContainerToStack(container);
        //                    }
        //                }

        //                if (!IsContainerSurrounded(containerSpots[currentNormalSpot], containerSpots[currentNormalSpot - WidthInContainers])
        //                    && !IsSurroundingContainerValuable(containerSpots[currentNormalSpot - WidthInContainers]))
        //                {
        //                    containerAdded = containerSpots[currentNormalSpot].TryAddingContainerToStack(container);
        //                }

        //                lastNormalSpot = currentNormalSpot;
        //                currentNormalSpot++;

        //                if (containerAdded) continue;
        //            }

        //            if (!containerAdded)
        //                throw new ArgumentException("Container could not be added to any of the normal spots!");
        //            else continue;
        //        }
        //        else if (container.HasCooling && container.HasValuables)
        //        {
        //            while (!containerAdded)
        //            {
        //                containerAdded = containerSpots[currentCooledSpot].TryAddingContainerToStack(container);
        //            }

        //            lastCooledSpot = currentCooledSpot;
        //            currentCooledSpot++;

        //            if (containerAdded) continue;

        //            if (!containerAdded)
        //                throw new ArgumentException("Container could not be added to any of the normal spots!");
        //            else continue;
        //        }
        //        else
        //        {
        //            while (!containerAdded)
        //            {
        //                if (containerSpots[currentNormalSpot].Containers.Count() + 1 == containerSpots[currentNormalSpot - WidthInContainers].Containers.Count())
        //                {
        //                    if (!IsSurroundingContainerValuable(containerSpots[currentNormalSpot - WidthInContainers]))
        //                    {
        //                        containerAdded = containerSpots[currentNormalSpot].TryAddingContainerToStack(container);
        //                    }

        //                    containerAdded = containerSpots[currentNormalSpot].TryAddingContainerToStack(container);
        //                }

        //                lastNormalSpot = currentNormalSpot;
        //                currentNormalSpot++;

        //                if (containerAdded) continue;
        //            }

        //            if (!containerAdded)
        //                throw new ArgumentException("Container could not be added to any of the normal spots!");
        //            else continue;
        //        }
        //    }
        //}

        private void CreateContainerStackRows()
        {
            for (int c = 0; c < LengthInContainers; c++)
            {
                containerStackRows.Add(new ContainerStackRow(WidthInContainers));
            }
        }

        public List<Container> SortContainers(List<Container> containersOnBay)
        {
            return containersOnBay.OrderByDescending(c => c.HasCooling)
                .ThenBy(c => c.HasValuables).ThenBy(c => c.Weight).ToList();
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

        //private void CheckShipWeightForSafety()
        //{
        //    IsHalfOfShipWeightUsed();

        //    int weightLeftSide = CalculateWeightOfSide(this, 0);
        //    int weightRightSide = CalculateWeightOfSide(this, WidthInContainers - 1);
        //    bool safeMargin = CalculateMarginOfSides(weightLeftSide, weightRightSide);
        //}

        private bool IsHalfOfShipWeightUsed()
        {
            return CurrentShipWeight >= MaxShipWeight / 2;
        }

        public int CalculateWeightLeftSide()
        {
            int totalweight = 0;

            return totalweight += containerStackRows.Sum(row => row.ContainerStacks.FirstOrDefault()!.StackWeight);
        }

        public int CalculateWeightRightSide()
        {
            int totalweight = 0;

            return totalweight += containerStackRows.Sum(row => row.ContainerStacks.LastOrDefault()!.StackWeight);
        }

        public bool CalculateMarginOfSides(int weightLeftSide, int weightRightSide)
        {
            return weightLeftSide >= weightRightSide * 0.8 && weightRightSide >= weightLeftSide * 0.8;
        }
        #endregion
    }
}
