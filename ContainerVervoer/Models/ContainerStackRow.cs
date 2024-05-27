using ContainerVervoer.Classes;

namespace ContainerVervoer.Models
{
    public class ContainerStackRow
    {
        public int StackRowWeight { get { return containerStacks.Sum(s => s.StackWeight); } }
        public IReadOnlyList<ContainerStack> ContainerStacks { get { return containerStacks; } }
        private List<ContainerStack> containerStacks { get; set; } = new();

        public ContainerStackRow(int width)
        {
            for (int i = 0; i < width; i++)
            {
                containerStacks.Add(new ContainerStack());
            }
        }

        public void TryToAddContainerToContainerStackRow(Container container)
        {
            bool containerAdded = false;

            foreach (ContainerStack stack in containerStacks)
            {
                if (!containerAdded) containerAdded = stack.TryAddingContainerToStack(container); else continue;
            }
        }
    }
}
