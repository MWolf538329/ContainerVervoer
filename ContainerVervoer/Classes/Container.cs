using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Classes
{
    public class Container
    {
        private const int _MAXCARRYWEIGHT = 120000; // Maximum Carry Weight 120 Ton
        private const int _MAXWEIGHT = 30000; // Maximum Container Weight 30 Ton
        private const int _MINWEIGHT = 4; // Minumum Container Weight 4 Ton

        public int ContainerWeight { get; private set; }
        public bool HasValuables {  get; private set; }
        public bool HasCooling { get; private set; }

        public Container(int weight, bool hasValuables, bool hasCooling)
        {
            ContainerWeight = weight;
            HasValuables = hasValuables;
            HasCooling = hasCooling;
        }
    }
}
