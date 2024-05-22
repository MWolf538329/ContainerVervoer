using ContainerVervoer.Classes;
using System.Windows.Forms;

namespace ContainerVervoerTests
{
    [TestClass]
    public class ContainerShipTests
    {
        [TestMethod]
        public void CheckMargin_Succes()
        {
            // 2 scenario's toevoegen met 80 - 100 en 100 - 80
            bool succes = ContainerShip.CalculateMarginOfSides(100, 100);

            Assert.AreEqual(true, succes);
        }
    }
}
