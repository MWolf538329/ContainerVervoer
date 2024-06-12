using ContainerVervoer.Models;

namespace ContainerVervoerTests
{
    [TestClass]
    public class ContainerShipTests
    {
        [TestMethod]
        public void CalculateWeightLeftSide()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, false, true); // top left
            ship.AddContainerToBay(25, false, true); // top right
            ship.AddContainerToBay(20, false, true); // top right
            ship.AddContainerToBay(24, true, true); // top left
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(25, false, false); // bottom left
            ship.AddContainerToBay(15, false, false); // bottom right
            ship.AddContainerToBay(10, true, false); // bottom right
            ship.DivideContainersOverShip();

            // Act
            int actual = ship.CalculateWeightLeftSide();

            // Assert
            Assert.AreEqual(139, actual);
        }

        [TestMethod]
        public void CalculateWeightRightSide()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, false, true); // top left
            ship.AddContainerToBay(25, false, true); // top right
            ship.AddContainerToBay(20, false, true); // top right
            ship.AddContainerToBay(24, true, true); // top left
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(25, false, false); // bottom left
            ship.AddContainerToBay(15, false, false); // bottom right
            ship.AddContainerToBay(10, true, false); // bottom right
            ship.DivideContainersOverShip();

            // Act
            int actual = ship.CalculateWeightRightSide();

            // Assert
            Assert.AreEqual(190, actual);
        }

        [TestMethod]
        public void CalculateMarginOfSides_Valid()
        {
            // Arrange
            bool lightLeftHeavyRight, leftRightEven, heavyLeftLightRight;
            ContainerShip ship = new(2, 2);

            // Act
            lightLeftHeavyRight = ship.CalculateMarginOfSides(80, 100);
            leftRightEven = ship.CalculateMarginOfSides(100, 100);
            heavyLeftLightRight = ship.CalculateMarginOfSides(100, 80);

            // Assert
            Assert.AreEqual(true, lightLeftHeavyRight);
            Assert.AreEqual(true, leftRightEven);
            Assert.AreEqual(true, heavyLeftLightRight);
        }

        [TestMethod]
        public void CalculateMarginOfSides_Invalid()
        {
            // Arrange
            bool biggerMargin, barelyValid, minusNumberUsed;
            ContainerShip ship = new(2, 2);

            // Act
            biggerMargin = ship.CalculateMarginOfSides(60, 120);
            barelyValid = ship.CalculateMarginOfSides(79, 100);
            minusNumberUsed = ship.CalculateMarginOfSides(-1, 100);

            // Assert
            Assert.AreEqual(false, biggerMargin);
            Assert.AreEqual(false, barelyValid);
            Assert.AreEqual(false, minusNumberUsed);
        }

        [TestMethod]
        public void CalculateMarginOfSides_ActualValid()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, false, true); // top left
            ship.AddContainerToBay(30, false, true); // top left
            ship.AddContainerToBay(25, false, true); // top right
            ship.AddContainerToBay(25, false, true); // top right
            ship.AddContainerToBay(20, false, true); // top right
            ship.AddContainerToBay(24, true, true); // top left
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.DivideContainersOverShip();

            // Act
            bool actual = ship.CalculateMarginOfSides(ship.CalculateWeightLeftSide(), ship.CalculateWeightRightSide());

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void CalculateMarginOfSides_ActualInvaid()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, false, true); // top left
            ship.AddContainerToBay(25, false, true); // top right
            ship.AddContainerToBay(20, false, true); // top right
            ship.AddContainerToBay(24, true, true); // top left
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(30, false, false); // bottom left
            ship.AddContainerToBay(30, false, false); // bottom right
            ship.AddContainerToBay(25, false, false); // bottom left
            ship.AddContainerToBay(15, false, false); // bottom right
            ship.AddContainerToBay(10, true, false); // bottom right
            ship.DivideContainersOverShip();

            // Act
            bool actual = ship.CalculateMarginOfSides(ship.CalculateWeightLeftSide(), ship.CalculateWeightRightSide());

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
