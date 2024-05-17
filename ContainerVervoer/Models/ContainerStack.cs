﻿namespace ContainerVervoer.Classes
{
    public class ContainerStack
    {
        public const int _MAXSTACKWEIGHT = 150; // Maximum Stack Weight 150 Ton
        public int StackWeight { get; private set; }
        public IEnumerable<Container> Containers { get { return containers; } }
        private List<Container> containers { get; set; }

        public ContainerStack()
        {
            containers = new();
        }

        public bool TryAddingContainerToStack(Container container)
        {
            if (DoesNotExceedStackWeightLimit(container) && DoesNotExceedCarryWeightLimit(container))
            {
                containers.Add(container);
                return true;
            }
            return false;
        }

        private bool DoesNotExceedStackWeightLimit(Container container)
        {
            return (DetermineStackWeight(containers) + container.Weight) <= ContainerStack._MAXSTACKWEIGHT;
        }

        private bool DoesNotExceedCarryWeightLimit(Container container)
        {
            return (DetermineStackWeight(Containers.Skip(1).ToList()) + container.Weight) <= Container._MAXCARRYWEIGHT;
        }

        private int DetermineStackWeight(List<Container> containers)
        {
            int weight = 0;

            foreach (Container container in containers)
            {
                weight += container.Weight;
            }

            return weight;
        }
    }
}