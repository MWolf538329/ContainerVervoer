using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Classes
{
    public class ContainerShip
    {
        public int LengthInContainers { get; private set; }
        public int WidthInContainers { get; private set; }
        public IEnumerable<List<Container>> ContainerSpots { get { return containerSpots; } }
        private List<List<Container>> containerSpots { get; set; }

        public ContainerShip(int length, int width)
        {
            LengthInContainers = length;
            WidthInContainers = width;

            containerSpots = CreateContainerGrid(LengthInContainers, WidthInContainers);
        }

        //public void AddContainerToShip(int weight, bool hasValuable, bool isCooled)
        //{

        //}

        public override string ToString()
        {
            return base.ToString();
        }

        private List<List<Container>> CreateContainerGrid(int length, int width)
        {
            List<List<Container>> containerGrid = new();

            for (int c = 0; c < length; c++)
            {
                for(int r = 0; r < width; r++)
                {
                    containerGrid.Add(new List<Container>());
                }
            }

            return containerGrid;
        }
    }
}
