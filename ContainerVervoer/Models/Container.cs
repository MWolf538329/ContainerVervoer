namespace ContainerVervoer.Classes
{
    public class Container
    {
        public const int _MAXCARRYWEIGHTINTON = 120;
        public const int _MAXWEIGHTINTON = 30;
        public const int _MINWEIGHTINTON = 4;

        public int Weight { get; private set; }
        public bool HasValuables {  get; private set; }
        public bool HasCooling { get; private set; }

        public Container(int weight, bool hasValuables, bool hasCooling)
        {
            if (!ContainerHasAcceptableWeight(weight))
                throw new ArgumentException("Container has invalid weight!");

            Weight = weight;
            HasValuables = hasValuables;
            HasCooling = hasCooling;
        }

        private bool ContainerHasAcceptableWeight(int weight)
        {
            return weight >= _MINWEIGHTINTON && weight <= _MAXWEIGHTINTON;
        }
    }
}