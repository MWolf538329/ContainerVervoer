using ContainerVervoer.Classes;

namespace ContainerVervoerTests
{
    [TestClass]
    public class ContainerTests
    {
        [TestMethod]
        public void ContainerHasAcceptableWeight()
        {
            // Arrange
            int weight = 25;
            bool hasCooling = false;
            bool hasValuables = false;

            // Act
            Container container = new(weight, hasCooling, hasValuables);

            // Assert
            Assert.AreEqual(25, container.Weight);
        }

        [TestMethod]
        public void ContainerHasUnacceptableWeight()
        {
            // Arrange
            int underWeight = 3;
            int overWeight = 40;
            bool hasCooling = false;
            bool hasValuables = false;

            // Act
            ArgumentException underLimit = Assert.ThrowsException<ArgumentException>(
                () => new Container(underWeight, hasCooling, hasValuables));

            ArgumentException overLimit = Assert.ThrowsException<ArgumentException>(
                () => new Container(overWeight, hasCooling, hasValuables));

            // Assert
            Assert.AreEqual("Container has invalid weight!", underLimit.Message);
            Assert.AreEqual("Container has invalid weight!", overLimit.Message);
        }
    }
}