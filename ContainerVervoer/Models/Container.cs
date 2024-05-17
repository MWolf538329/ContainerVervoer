namespace ContainerVervoer.Classes
{
    public class Container
    {
        public const int _MAXCARRYWEIGHT = 120; // Maximum Carry Weight 120 Ton
        public const int _MAXWEIGHT = 30; // Maximum Container Weight 30 Ton
        public const int _MINWEIGHT = 4; // Minumum Container Weight 4 Ton

        public int Weight { get; private set; }
        public bool HasValuables {  get; private set; }
        public bool HasCooling { get; private set; }

        public Container(int weight, bool hasValuables, bool hasCooling)
        {
            Weight = weight;
            HasValuables = hasValuables;
            HasCooling = hasCooling;
        }
    }
}
