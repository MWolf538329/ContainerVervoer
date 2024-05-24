namespace ContainerVervoer.Classes
{
    public class ContainerStack
    {
        public const int _MAXSTACKWEIGHTINTON = 150;

        public int StackWeight { get; private set; }
        public IEnumerable<Container> Containers { get { return containers; } }
        private List<Container> containers { get; set; }

        public ContainerStack()
        {
            containers = new();
        }

        public bool TryAddingContainerToStack(Container container)
        {
            if (containers.Count != 0)
            {
                if (DoesNotExceedStackWeightLimit(container) && DoesNotExceedCarryWeightLimit(container))
                {
                    if (!NotOnTopOfValuableContainer(container))
                    {
                        containers.Add(container);
                        StackWeight = DetermineStackWeight(containers);
                        return true;
                    }
                }
            }
            else
            {
                containers.Add(container);
                StackWeight = DetermineStackWeight(containers);
                return true;
            }
            
            return false;
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

        #region Checks
        private bool DoesNotExceedStackWeightLimit(Container container)
        {
            return (DetermineStackWeight(containers) + container.Weight) <= ContainerStack._MAXSTACKWEIGHTINTON;
        }

        private bool DoesNotExceedCarryWeightLimit(Container container)
        {
            return (DetermineStackWeight(containers.Skip(1).ToList()) + container.Weight) <= Container._MAXCARRYWEIGHTINTON;
        }

        private bool NotOnTopOfValuableContainer(Container container)
        {
            return containers.LastOrDefault()!.HasValuables;
        }
        #endregion
    }
}
