using ContainerVervoer.Models;

namespace ContainerVervoerTests
{
    [TestClass]
    public class ContainerStackRowTests
    {
        [TestMethod]
        public void CheckIfDividedWidthIsCorrect()
        {
            // Arrange
            ContainerShip shipOneByOne = new(1, 1);
            ContainerShip shipTwoByTwo = new(2,2);
            ContainerShip shipThreeByThree = new(3, 3);
            ContainerShip shipFourByFour = new(4, 4);
            ContainerShip shipFiveByFive = new(5, 5);
            ContainerShip shipSixBySix = new(6, 6);
            ContainerShip shipSevenBySeven = new(7, 7);
            ContainerShip shipEightByEight = new(8, 8);
            ContainerShip shipNineByNine = new(9, 9);
            ContainerShip shipTenByTen = new(10, 10);
            ContainerShip shipElevenByEleven = new(11, 11);
            ContainerShip shipSeventeenBySeventeen = new(17, 17);

            // Assert
            Assert.AreEqual(0, shipOneByOne.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(1, shipTwoByTwo.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(1, shipThreeByThree.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(2, shipFourByFour.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(2, shipFiveByFive.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(3, shipSixBySix.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(3, shipSevenBySeven.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(4, shipEightByEight.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(4, shipNineByNine.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(5, shipTenByTen.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(5, shipElevenByEleven.ContainerStackRows[0].dividedWidth);
            Assert.AreEqual(8, shipSeventeenBySeventeen.ContainerStackRows[0].dividedWidth);
        }
    }
}
