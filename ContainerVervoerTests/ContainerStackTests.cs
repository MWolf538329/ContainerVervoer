using ContainerVervoer.Classes;

namespace ContainerVervoerTests
{
    [TestClass]
    public class ContainerStackTests
    {
        private Container lightContainer { get; } = new Container(5, false, false);
        private Container defaultContainer { get; } = new Container(30, false, false); 
        private Container container { get; } = new Container(25, false, false);

        private Container valuableContainer { get; } = new Container(20, true, false);


        [TestMethod]
        public void TryAddingContainerToStackSucces()
        {
            // Arrange
            ContainerStack stack = new();
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);

            // Act
            bool succes = stack.TryAddingContainerToStack(container);

            // Assert
            Assert.AreEqual(true, succes);
            Assert.AreEqual(3, stack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStackExceedStackWeight()
        {
            // Arrange
            ContainerStack stack = new();
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(new Container(20, false, false));

            // Act
            bool succes = stack.TryAddingContainerToStack(container);

            // Assert
            Assert.AreEqual(false, succes);
            Assert.AreEqual(5, stack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStackExceedCarryWeight()
        {
            // Arrange
            ContainerStack stack = new();
            stack.TryAddingContainerToStack(lightContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);

            // Act
            bool succes = stack.TryAddingContainerToStack(lightContainer);

            // Assert
            Assert.AreEqual(false, succes);
            Assert.AreEqual(5, stack.Containers.Count());
        }

        public void TryAddingContainerToStackNormalContainerOnTopOfValuableContainer()
        {
            // Arrange
            ContainerStack stack = new();
            stack.TryAddingContainerToStack(valuableContainer);

            // Act
            bool succes = stack.TryAddingContainerToStack(defaultContainer);

            // Assert
            Assert.AreEqual(false, succes);
            Assert.AreEqual(1, stack.Containers.Count());
        }
    }
}
