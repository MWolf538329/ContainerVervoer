namespace ContainerVervoer.Classes
{
    public class ContainerStack
    {
        public const int MAXSTACKWEIGHT = 150000;
        public int StackWeight { get; set; }
        public List<Container> Containers { get; set; } = new();

        public void TryAddingContainerToStack()
        {

        }

        public int DetermineStackWeight()
        {
            int weight = 0;

            foreach (Container container in Containers)
            {
                weight =+ container.ContainerWeight;
            }

            return weight;
        }

        private bool DoesNotExceedWeightLimit()
        {
            return true;
        }

        private bool DoesNotExceedCarryWeight()
        {
            return true;
        }
    }
}
