using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace ContainerVervoer.Classes
{
    public class ContainerShip
    {
        public int LengthInContainers { get; private set; }
        public int WidthInContainers { get; private set; }
        public static int MaxShipWeight { get; private set; }
        public IEnumerable<List<ContainerStack>> ContainerSpots { get { return containerSpots; } }
        private List<List<ContainerStack>> containerSpots { get; set; } = new();
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

            foreach (Container container in containers)
            {
                if (container.HasCooling)
                {
                    for (int frontSpots = 0; frontSpots < WidthInContainers; frontSpots++)
                    {
                        containerSpots[frontSpots].Add(container);
                        frontSpots++;

                        if (frontSpots > WidthInContainers)
                        {
                            frontSpots = 0;
                        }
                    }
                }
                else if (!container.HasCooling && !container.HasValuables)
                {
                    for(int restSpots = WidthInContainers; restSpots < containerSpots.Count; restSpots++)
                    {
                        containerSpots[restSpots].Add(container);
                        restSpots++;

                        if (restSpots > containerSpots.Count)
                        {
                            restSpots = WidthInContainers;
                        }
                    }
                }
                else if (container.HasValuables)
                {
                    for (int restSpots = WidthInContainers; restSpots < containerSpots.Count; restSpots++)
                    {
                        containerSpots[restSpots].Add(container);
                        restSpots++;

                        if (restSpots > containerSpots.Count)
                        {
                            restSpots = WidthInContainers;
                        }
                    }
                }
            }
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
    }
}
