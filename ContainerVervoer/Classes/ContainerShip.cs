using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Classes
{
    public class ContainerShip
    {
        public int LengthInContainers { get; private set; }
        public int WidthInContainers { get; private set; }

        public ContainerShip(int length, int width)
        {
            LengthInContainers = length;
            WidthInContainers = width;
        }
    }
}
