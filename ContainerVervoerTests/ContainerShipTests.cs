using ContainerVervoer.Classes;

namespace ContainerVervoerTests
{
    [TestClass]
    public class ContainerShipTests
    {
        [TestMethod]
        public void CalculateWeightOnSide_Valid()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, false, true); // Left
            ship.AddContainerToBay(30, false, true); // Right
            ship.AddContainerToBay(30, false, true); // Left
            ship.AddContainerToBay(30, false, false); // Left
            ship.AddContainerToBay(30, false, false); // Right
            ship.AddContainerToBay(30, false, false); // Left
            ship.AddContainerToBay(30, false, false); // Right
            ship.AddContainerToBay(30, false, false); // Left
            ship.AddContainerToBay(30, false, false); // Right
            ship.AddContainerToBay(30, false, false); // Left
            ship.AddContainerToBay(30, false, false); // Right

            ship.DivideContainersOverShip();

            // Act
            int weightLeftSide = ContainerShip.CalculateWeightOnSide(ship, 0);
            int weightRightSide = ContainerShip.CalculateWeightOnSide(ship, ship.WidthInContainers - 1);

            // Assert
            Assert.AreEqual(600, ship.MaxShipWeight);
            Assert.AreEqual(180, weightLeftSide);
            Assert.AreEqual(150, weightRightSide);
        }

        //[TestMethod]
        //public void CalculateWeightOnSide_Invalid()
        //{
        //    // Arrange
        //    ContainerShip ship = new(2, 2);
        //    ship.AddContainerToBay(30, false, true); // Left
        //    ship.AddContainerToBay(30, false, true); // Right
        //    ship.AddContainerToBay(30, false, true); // Left
        //    ship.AddContainerToBay(30, false, false); // Left
        //    ship.AddContainerToBay(30, false, false); // Right
        //    ship.AddContainerToBay(30, false, false); // Left

        //    ship.DivideContainersOverShip();

        //    // Act
        //    int weightLeftSide = ContainerShip.CalculateWeightOnSide(ship, 0);
        //    int weightRightSide = ContainerShip.CalculateWeightOnSide(ship, ship.WidthInContainers - 1);

        //    // Assert
        //    Assert.AreEqual(600, ship.MaxShipWeight);
        //    Assert.AreEqual(180, weightLeftSide);
        //    Assert.AreEqual(150, weightRightSide);
        //}

        [TestMethod]
        public void CalculateMarginOfSides_Valid()
        {
            // Act
            bool lightLeftHeavyRight = ContainerShip.CalculateMarginOfSides(80, 100);
            bool leftRightEven = ContainerShip.CalculateMarginOfSides(100, 100);
            bool heavyLeftLightRight = ContainerShip.CalculateMarginOfSides(100, 80);

            // Assert
            Assert.AreEqual(true, lightLeftHeavyRight);
            Assert.AreEqual(true, leftRightEven);
            Assert.AreEqual(true, heavyLeftLightRight);
        }

        [TestMethod]
        public void CalculateMarginOfSides_Invalid()
        {
            // Act
            bool biggerMargin = ContainerShip.CalculateMarginOfSides(60, 120);
            bool barelyValid = ContainerShip.CalculateMarginOfSides(79, 100);

            // Assert
            Assert.AreEqual(false, biggerMargin);
            Assert.AreEqual(false, barelyValid);
        }
    }
}
