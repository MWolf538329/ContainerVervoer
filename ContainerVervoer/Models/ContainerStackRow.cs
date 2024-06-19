namespace ContainerVervoer.Models
{
    public class ContainerStackRow
    {
        public int StackRowWeight { get { return containerStacks.Sum(s => s.StackWeight); } }
        public int StackRowWeightLeftSide { get { return CalculateStackRowWeightLeftSide(); } }
        public int StackRowWeightRightSide { get { return CalculateStackRowWeightRightSide(); } }
        public double dividedWidth { get { return Math.Round(Convert.ToDouble(containerStacks.Count()) / 2, MidpointRounding.ToZero); } }
        public IReadOnlyList<ContainerStack> ContainerStacks { get { return containerStacks; } }
        private List<ContainerStack> containerStacks { get; set; } = new();

        public ContainerStackRow(int width)
        {
            for (int i = 0; i < width; i++)
            {
                containerStacks.Add(new ContainerStack());
            }
        }

        public bool TryToAddContainerToContainerStackRow(Container container)
        {
            bool containerAdded = false;

            containerStacks = containerStacks.OrderBy(c => c.StackWeight).ToList();

            foreach (ContainerStack stack in containerStacks)
            {
                if (!containerAdded) containerAdded = stack.TryAddingContainerToStack(container); else continue;
            }

            return containerAdded;
        }

        public bool TryToAddValuableContainerToContainerStackRow(Container container, ContainerStackRow? frontRow, ContainerStackRow? backRow)
        {
            bool containerAdded = false;

            for (int i = 0; i < containerStacks.Count; i++)
            {
                if (!containerAdded)
                {
                    if (containerStacks[i].Containers.Count() + 1 > frontRow?.containerStacks[i].Containers.Count ||
                        containerStacks[i].Containers.Count() + 1 > backRow?.containerStacks[i].Containers.Count)
                    {
                        containerAdded = containerStacks[i].TryAddingContainerToStack(container);
                    }
                }
            }

            return containerAdded;
        }

        private int CalculateStackRowWeightLeftSide()
        {
            return containerStacks.Take(Convert.ToInt32(dividedWidth)).ToList().Sum(s => s.StackWeight);
        }

        private int CalculateStackRowWeightRightSide()
        {
            return containerStacks.TakeLast(Convert.ToInt32(dividedWidth)).ToList().Sum(s => s.StackWeight);
        }
    }
}
