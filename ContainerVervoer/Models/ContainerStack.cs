namespace ContainerVervoer.Classes
{
    public class ContainerStack
    {
        public const int _MAXSTACKWEIGHTINTON = 150;

        public int StackWeight { get { return containers.Sum(e => e.Weight); } }
        public IReadOnlyList<Container> Containers { get { return containers; } }
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
                        return true;
                    }
                }
            }
            else
            {
                containers.Add(container);
                return true;
            }
            
            return false;
        }

        #region Checks
        private bool DoesNotExceedStackWeightLimit(Container container)
        {
            return (StackWeight + container.Weight) <= ContainerStack._MAXSTACKWEIGHTINTON;
        }

        private bool DoesNotExceedCarryWeightLimit(Container container)
        {
            return ((StackWeight - containers.FirstOrDefault()!.Weight) + container.Weight) <= Container._MAXCARRYWEIGHTINTON;
        }

        private bool NotOnTopOfValuableContainer(Container container)
        {
            return containers.LastOrDefault()!.HasValuables;
        }
        #endregion
    }
}
