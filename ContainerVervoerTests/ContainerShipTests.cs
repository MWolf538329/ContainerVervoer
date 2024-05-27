using ContainerVervoer.Classes;

namespace ContainerVervoerTests
{
    [TestClass]
    public class ContainerShipTests
    {




        [TestMethod]
        public void SortContainers()
        {
            // Arrange
            List<Container> containers = new List<Container>()
            {
                new Container(22, false, false),
                new Container(23, true, false),
                new Container(16, false, true),
                new Container(24, true, true),
                new Container(30, false, false)
            };

            // Act
            containers = ContainerShip.SortContainers(containers);
            // Expected:
            // (16, false, true) -> (24, true, true) -> (22, false, false) -> (30, false, false) -> (23, true, false)

            // Assert
            Assert.AreEqual(16, containers.ElementAt(0).Weight);
            Assert.AreEqual(false, containers.ElementAt(0).HasValuables);
            Assert.AreEqual(true, containers.ElementAt(0).HasCooling);

            Assert.AreEqual(24, containers.ElementAt(1).Weight);
            Assert.AreEqual(true, containers.ElementAt(1).HasValuables);
            Assert.AreEqual(true, containers.ElementAt(1).HasCooling);

            Assert.AreEqual(22, containers.ElementAt(2).Weight);
            Assert.AreEqual(false, containers.ElementAt(2).HasValuables);
            Assert.AreEqual(false, containers.ElementAt(2).HasCooling);

            Assert.AreEqual(30, containers.ElementAt(3).Weight);
            Assert.AreEqual(false, containers.ElementAt(3).HasValuables);
            Assert.AreEqual(false, containers.ElementAt(3).HasCooling);

            Assert.AreEqual(23, containers.ElementAt(4).Weight);
            Assert.AreEqual(true, containers.ElementAt(4).HasValuables);
            Assert.AreEqual(false, containers.ElementAt(4).HasCooling);
        }


        [TestMethod]
        public void DivideContainersOverShip_CooledContainers()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, false, true);
            ship.AddContainerToBay(29, false, true);
            ship.AddContainerToBay(28, false, true);

            // Act
            ship.DivideContainersOverShip();

            // Assert
            Assert.AreEqual(2, ship.ContainerSpots.ElementAt(0).Containers.Count());
            Assert.AreEqual(58, ship.ContainerSpots.ElementAt(0).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(1).Containers.Count());
            Assert.AreEqual(29, ship.ContainerSpots.ElementAt(1).StackWeight);

            Assert.AreEqual(0, ship.ContainerSpots.ElementAt(2).Containers.Count());
            Assert.AreEqual(0, ship.ContainerSpots.ElementAt(3).Containers.Count());
        }

        [TestMethod]
        public void DivideContainersOverShip_NormalContainers()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, false, false);
            ship.AddContainerToBay(29, false, false);
            ship.AddContainerToBay(28, false, false);

            // Act
            ship.DivideContainersOverShip();

            // Assert
            Assert.AreEqual(0, ship.ContainerSpots.ElementAt(0).Containers.Count());
            Assert.AreEqual(0, ship.ContainerSpots.ElementAt(1).Containers.Count());

            Assert.AreEqual(2, ship.ContainerSpots.ElementAt(2).Containers.Count());
            Assert.AreEqual(58, ship.ContainerSpots.ElementAt(2).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(3).Containers.Count());
            Assert.AreEqual(29, ship.ContainerSpots.ElementAt(3).StackWeight);
        }

        [TestMethod]
        public void DivideContainersOverShip_ValuableContainers()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, true, false);
            ship.AddContainerToBay(29, true, false);

            // Act
            ship.DivideContainersOverShip();

            // Assert
            Assert.AreEqual(0, ship.ContainerSpots.ElementAt(0).Containers.Count());
            Assert.AreEqual(0, ship.ContainerSpots.ElementAt(1).Containers.Count());

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(2).Containers.Count());
            Assert.AreEqual(30, ship.ContainerSpots.ElementAt(2).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(3).Containers.Count());
            Assert.AreEqual(29, ship.ContainerSpots.ElementAt(3).StackWeight);
        }


        [TestMethod]
        public void AllWorking()
        {
            // Arrange
            ContainerShip ship = new(3, 3);

            ship.AddContainerToBay(30, false, true);
            ship.AddContainerToBay(29, false, true);
            ship.AddContainerToBay(28, false, true);
            ship.AddContainerToBay(20, true, true);
            ship.AddContainerToBay(27, false, false);
            ship.AddContainerToBay(26, false, false);
            ship.AddContainerToBay(25, false, false);
            ship.AddContainerToBay(24, false, false);
            ship.AddContainerToBay(23, false, false);
            ship.AddContainerToBay(22, true, false);
            ship.AddContainerToBay(21, true, false);

            // Act
            ship.DivideContainersOverShip();

            // Assert
            Assert.AreEqual(2, ship.ContainerSpots.ElementAt(0).Containers.Count());
            Assert.AreEqual(50, ship.ContainerSpots.ElementAt(0).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(1).Containers.Count());
            Assert.AreEqual(29, ship.ContainerSpots.ElementAt(1).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(2).Containers.Count());
            Assert.AreEqual(28, ship.ContainerSpots.ElementAt(2).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(3).Containers.Count());
            Assert.AreEqual(27, ship.ContainerSpots.ElementAt(3).StackWeight);

            Assert.AreEqual(2, ship.ContainerSpots.ElementAt(4).Containers.Count());
            Assert.AreEqual(47, ship.ContainerSpots.ElementAt(4).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(5).Containers.Count());
            Assert.AreEqual(25, ship.ContainerSpots.ElementAt(5).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(6).Containers.Count());
            Assert.AreEqual(24, ship.ContainerSpots.ElementAt(6).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(7).Containers.Count());
            Assert.AreEqual(23, ship.ContainerSpots.ElementAt(7).StackWeight);

            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(8).Containers.Count());
            Assert.AreEqual(22, ship.ContainerSpots.ElementAt(8).StackWeight);
        }

        [TestMethod]
        public void CalculateWeightOnSide_2By2()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, false, true); // Left Cooled
            ship.AddContainerToBay(29, false, true); // Right Cooled
            ship.AddContainerToBay(28, false, true); // Left Cooled
            ship.AddContainerToBay(27, false, false); // Left
            ship.AddContainerToBay(26, false, false); // Right
            ship.AddContainerToBay(25, false, false); // Left
            ship.DivideContainersOverShip();

            // Act
            int leftWeight = ContainerShip.CalculateWeightOfSide(ship, 0);
            int rightWeight = ContainerShip.CalculateWeightOfSide(ship, ship.WidthInContainers - 1);

            // Assert
            Assert.AreEqual(110, leftWeight);
            Assert.AreEqual(55, rightWeight);
        }

        [TestMethod]
        public void CalculateWeightOnSide_temptest()
        {
            // Arrange
            ContainerShip ship = new(2, 2);

            ship.AddContainerToBay(30, false, true);
            ship.AddContainerToBay(29, false, true);
            ship.AddContainerToBay(28, false, true);
            ship.DivideContainersOverShip();

            // Act
            int leftWeight = ContainerShip.CalculateWeightOfSide(ship, 0);
            int rightWeight = ContainerShip.CalculateWeightOfSide(ship, ship.WidthInContainers - 1);

            // Assert
            Assert.AreEqual(58, leftWeight);
            Assert.AreEqual(29, rightWeight);
        }

        [TestMethod]
        public void ThreeCooledContainersAddedCorrectly()
        {
            // Arrange
            ContainerShip ship = new(2, 2);

            ship.AddContainerToBay(30, false, true);
            ship.AddContainerToBay(29, false, true);
            ship.AddContainerToBay(28, false, true);

            // Act
            ship.DivideContainersOverShip();

            // Assert
            Assert.AreEqual(2, ship.ContainerSpots.ElementAt(0).Containers.Count());
            Assert.AreEqual(1, ship.ContainerSpots.ElementAt(1).Containers.Count());
        }

        [TestMethod]
        public void CalculateWeightOnSide_Valid()
        {
            // Arrange
            ContainerShip ship = new(2, 2);
            ship.AddContainerToBay(30, false, true); // Left Cooled
            ship.AddContainerToBay(30, false, true); // Right Cooled
            ship.AddContainerToBay(30, false, true); // Left Cooled
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
            int weightLeftSide = ContainerShip.CalculateWeightOfSide(ship, 0);
            int weightRightSide = ContainerShip.CalculateWeightOfSide(ship, ship.WidthInContainers - 1);

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
        //    int weightLeftSide = ContainerShip.CalculateWeightOfSide(ship, 0);
        //    int weightRightSide = ContainerShip.CalculateWeightOfSide(ship, ship.WidthInContainers - 1);

        //    // Assert
        //    Assert.AreEqual(600, ship.MaxShipWeight);
        //    Assert.AreEqual(180, weightLeftSide);
        //    Assert.AreEqual(150, weightRightSide);
        //}

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
    }
}
