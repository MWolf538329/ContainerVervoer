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
        public static int MaxShipWeight { get; private set; }
        public IEnumerable<List<Container>> ContainerSpots { get { return containerSpots; } }
        private List<List<Container>> containerSpots { get; set; } = new();
        public IEnumerable<Container> Containers { get { return containers; } }
        private List<Container> containers { get; set; } = new();

        public ContainerShip(int length, int width)
        {
            LengthInContainers = length;
            WidthInContainers = width;
            CreateContainerSpots(LengthInContainers, WidthInContainers);
            MaxShipWeight = (containerSpots.Count * 150000);
        }

        public void AddContainer(int weight, bool hasValuable, bool isCooled)
        {
            containers.Add(new Container(weight, hasValuable, isCooled));
        }

        public void DevideContainersOverShip()
        {
            SortContainers();

            //if ()
            //{

            //}
        }

        public override string ToString()
        {
            return base.ToString();
        }

        private void CreateContainerSpots(int length, int width)
        {
            for (int c = 0; c < length; c++)
            {
                for(int r = 0; r < width; r++)
                {
                    containerSpots.Add(new List<Container>());
                }
            }
        }

        private void SortContainers()
        {
            containers = containers.OrderByDescending(c => c.HasCooling).ThenBy(c => c.HasValuables).ToList();
        }

        //private bool 
    }
}
