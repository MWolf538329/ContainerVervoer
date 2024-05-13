using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Classes
{
    public class Container
    {
        public const int _MAXCARRYWEIGHT = 120000; // Maximum Carry Weight 120 Ton
        public const int _MAXWEIGHT = 30000; // Maximum Container Weight 30 Ton
        public const int _MINWEIGHT = 4; // Minumum Container Weight 4 Ton

        public int ContainerWeight { get; private set; }
        public bool HasValuables {  get; private set; }
        public bool HasCooling { get; private set; }

        public Container(int weight, bool hasValuables, bool hasCooling)
        {
            try
            {
                if (AcceptableWeight(weight))
                {
                    ContainerWeight = weight;
                }
                else
                {
                    throw new Exception("Unacceptable Weight!");
                }

                HasValuables = hasValuables;
                HasCooling = hasCooling;
            }
            catch (Exception)
            {
                throw new Exception("Oopsy daisy");
            }
        }

        public override string ToString()
        {
            return $"[{ContainerWeight} Ton - {HasValuables} - {HasCooling}]";
        }

        private bool AcceptableWeight(int weight)
        {
            bool result = false;

            if (weight > _MINWEIGHT && weight < _MAXWEIGHT)
            {
                result = true;
            }

            return result;
        }
    }
}
