namespace ContainerVervoer.Classes
{
    public class ContainerShip
    {
        public int LengthInContainers { get; private set; }
        public int WidthInContainers { get; private set; }
        public static int MaxShipWeight { get; private set; }
        public IEnumerable<ContainerStack> ContainerSpots { get { return containerSpots; } }
        private List<ContainerStack> containerSpots { get; set; } = new();
        public IEnumerable<Container> ContainersOnBay { get { return containersOnBay; } }
        private List<Container> containersOnBay { get; set; } = new();

        public ContainerShip(int length, int width)
        {
            LengthInContainers = length;
            WidthInContainers = width;
            CreateContainerSpots(LengthInContainers, WidthInContainers);
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



                        // Second Draft:
                        //            while (!containerAdded)
                        //            {
                        //                if (currentCooledSpot != 0)
                        //                {
                        //                    if (currentCooledSpot != lastCooledSpot)
                        //                    {
                        //                        containerAdded = containerSpots[currentCooledSpot].TryAddingContainerToStack(container);
                        //                        continue;
                        //                    }
                        //                }
                        //                else
                        //                {
                        //                    containerAdded = containerSpots[currentCooledSpot].TryAddingContainerToStack(container);
                        //                    continue;
                        //                }
                        //            }
                        //            lastCooledSpot = currentCooledSpot;
                        //            currentCooledSpot++;
                        //        }
                        //    }
                        //    else if (!container.HasCooling && !container.HasValuables)
                        //    {


                        //        currentNormalSpot++;
                        //    }
                        //    else
                        //    {


                        //        currentNormalSpot++;
                        //    }
                        //}
                        // --------------


                        // First Draft:
                        //foreach (Container container in containersOnBay)
                        //{
                        //    if (container.HasCooling)
                        //    {
                        //        for (int frontSpots = 0; frontSpots < WidthInContainers; frontSpots++)
                        //        {
                        //            containerSpots[frontSpots].TryAddingContainerToStack(container);
                        //            frontSpots++;

                        //            if (frontSpots > WidthInContainers)
                        //            {
                        //                frontSpots = 0;
                        //            }
                        //        }
                        //    }
                        //    else if (!container.HasCooling && !container.HasValuables)
                        //    {
                        //        for(int restSpots = WidthInContainers; restSpots < containerSpots.Count; restSpots++)
                        //        {
                        //            containerSpots[restSpots].TryAddingContainerToStack(container);
                        //            restSpots++;

                        //            if (restSpots > containerSpots.Count)
                        //            {
                        //                restSpots = WidthInContainers;
                        //            }
                        //        }
                        //    }
                        //    else if (container.HasValuables)
                        //    {
                        //        for (int restSpots = WidthInContainers; restSpots < containerSpots.Count; restSpots++)
                        //        {
                        //            containerSpots[restSpots].TryAddingContainerToStack(container);
                        //            restSpots++;

                        //            if (restSpots > containerSpots.Count)
                        //            {
                        //                restSpots = WidthInContainers;
                        //            }
                        // --------------
                    }
                }
            }
        }

        private void CreateContainerSpots(int length, int width)
        {
            for (int c = 0; c < length; c++)
            {
                for(int r = 0; r < width; r++)
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

            containersOnBay = containersOnBay.OrderByDescending(c => c.HasCooling).ThenBy(c => c.HasValuables).ToList();
        }
    }
}
