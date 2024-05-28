using System.Diagnostics.Eventing.Reader;

namespace ContainerVervoer.Models
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

        public void DivideContainersOverShip()
        {
            try
            {
                if (WillHalfOfShipWeightBeUsed() && ContainersOnBayWeightDoNotExceedMaxShipWeight())
                {
                    SortContainers();

                    TryToPlaceCooledContainers();

                    TryToPlaceNormalContainers();

                    TryToPlaceValuableContainers();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TryToPlaceCooledContainers()
        {
            List<Container> cooledContainers = containersOnBay.Where(c => c.HasCooling).ToList();

            foreach (Container cooledContainer in cooledContainers)
            {
                containerStackRows[0].TryToAddContainerToContainerStackRow(cooledContainer);
            }
        }

        private void TryToPlaceNormalContainers()
        {
            List<Container> normalContainers = containersOnBay.Where(c => !c.HasCooling).Where(c => !c.HasValuables).ToList();

            foreach (Container normalContainer in normalContainers)
            {
                for (int i = 0; i < containerStackRows.Count(); i++)
                {

                }
            }
        }

        private void TryToPlaceValuableContainers()
        {
            List<Container> valuableContaniers = containersOnBay.Where(c => !c.HasCooling).Where(c => c.HasValuables).ToList();

            foreach (Container valuableContainer in valuableContaniers)
            {
                bool containerAdded = false;

                for (int i = 0; i < containerStackRows.Count(); i++)
                {
                    if (!containerAdded)
                    {
                        containerStackRows[i].TryToAddValuableContainerToContainerStackRow(
                        valuableContainer, containerStackRows[i - WidthInContainers], containerStackRows[i + WidthInContainers]);
                    }
                }
            }
        }

        private void CreateContainerStackRows()
        {
            for (int c = 0; c < LengthInContainers; c++)
            {
                containerStackRows.Add(new ContainerStackRow(WidthInContainers));
            }
        }

        public void SortContainers()
        {
            containersOnBay.OrderByDescending(c => c.HasCooling).ThenBy(c => c.HasValuables).ThenBy(c => c.Weight).ToList();
        }

        public bool WillHalfOfShipWeightBeUsed()
        {
            return containersOnBay.Sum(c => c.Weight) >= MaxShipWeight / 2 ? true : throw new ArgumentException("Totalweight is lower than shipweight!");
        }

        public bool ContainersOnBayWeightDoNotExceedMaxShipWeight()
        {
            return containersOnBay.Sum(c => c.Weight) <= MaxShipWeight ? true : throw new ArgumentException("Totalweight exceeds shipweight!");
        }

        #region Checks
        //private void CheckShipWeightForSafety()
        //{
        //    IsHalfOfShipWeightUsed();

        //    int weightLeftSide = CalculateWeightOfSide(this, 0);
        //    int weightRightSide = CalculateWeightOfSide(this, WidthInContainers - 1);
        //    bool safeMargin = CalculateMarginOfSides(weightLeftSide, weightRightSide);
        //}

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
