namespace ContainerVervoer.Classes
{
    public class ContainerShip
    {
        public int LengthInContainers { get; private set; }
        public int WidthInContainers { get; private set; }
        public static int MaxShipWeight { get; private set; }
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
            
            
            SortContainers();

            foreach (Container container in containersOnBay)
            {
                bool containerAdded = false;

                // Resetting Current Variables
                if (currentCooledSpot == WidthInContainers) currentCooledSpot = 0;
                if (currentNormalSpot == containerSpots.Count()) currentNormalSpot = WidthInContainers;

                if (container.HasCooling)
                {
                    foreach (ContainerStack cooledSpot in containerSpots.Take(WidthInContainers))
                    {
                        containerAdded = cooledSpot.TryAddingContainerToStack(container);
                        continue;
                    }

                    if (!containerAdded) 
                        throw new ArgumentException("Container could not be added to any of the cooled spots!"); 
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
            return currentStack.Containers.Count() + 1 >= surroundingStack.Containers.Count();
        }

        private bool IsSurroundingContainerValuable(ContainerStack surroundingStack)
        {
            return surroundingStack.Containers.Last().HasValuables;
        }

        private void CheckShipWeightForSafety()
        {
            IsHalfOfShipWeightUsed();

            int weightLeftSide = CalculateWeightOnSide(0);
            int weightRightSide = CalculateWeightOnSide(WidthInContainers - 1);
            bool safeMargin = CalculateMarginOfSides(weightLeftSide, weightRightSide);
        }

        private bool IsHalfOfShipWeightUsed()
        {
            return CurrentShipWeight >= MaxShipWeight / 2;
        }

        private int CalculateWeightOnSide(int index)
        {
            int totalWeight = 0;

            for (int i = 0; i < containerSpots.Count() / WidthInContainers; i++)
            {
                totalWeight += containerSpots[index].StackWeight;
                index += WidthInContainers;
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
