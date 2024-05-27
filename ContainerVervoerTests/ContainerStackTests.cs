using ContainerVervoer.Classes;

namespace ContainerVervoerTests
{
    [TestClass]
    public class ContainerStackTests
    {
        private Container lightContainer { get; } = new Container(5, false, false);
        private Container defaultContainer { get; } = new Container(30, false, false);
        private Container normalContainer { get; } = new Container(25, false, false);
        private Container valuableContainer { get; } = new Container(20, true, false);
        private Container cooledContainer { get; } = new Container(30, false, true);
        private Container cooledValuableContainer { get; } = new Container(22, true, true);

        [TestMethod]
        public void DetermineStackWeight()
        {
            // Arrange
            ContainerStack stack = new ContainerStack();
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(lightContainer);

            // Act
            int stackWeight = ContainerStack.DetermineStackWeight(stack.Containers.ToList());

            // Assert
            Assert.AreEqual(35, stackWeight);
        }

        [TestMethod]
        public void TryAddingContainerToStack_DoesNotExceedStackWeight()
        {
            // Arrange
            ContainerStack stack = new();
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(new Container(20, false, false));

            // Act
            bool succes = stack.TryAddingContainerToStack(normalContainer);

            // Assert
            Assert.AreEqual(true, succes);
            Assert.AreEqual(4, stack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStack_ExceedStackWeight()
        {
            // Arrange
            ContainerStack stack = new();
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(defaultContainer);
            stack.TryAddingContainerToStack(new Container(20, false, false));

            // Act
            bool succes = stack.TryAddingContainerToStack(normalContainer);

            // Assert
            Assert.AreEqual(false, succes);
            Assert.AreEqual(5, stack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStack_ExceedCarryWeight()
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

        [TestMethod]
        public void TryAddingContainerToStack_DoesNotExceedCarryWeight()
        {
            // Arrange
            ContainerStack stack = new();
            stack.TryAddingContainerToStack(lightContainer);
            stack.TryAddingContainerToStack(defaultContainer);

            // Act
            bool succes = stack.TryAddingContainerToStack(lightContainer);

            // Assert
            Assert.AreEqual(true, succes);
            Assert.AreEqual(3, stack.Containers.Count());
        }

        #region TryAddingContainerToStack_DifferentCombinations
        [TestMethod]
        public void TryAddingContainerToStack_CooledContainerOnTopOfCooledContainer()
        {
            // Arrange
            ContainerStack cooledStack = new();
            cooledStack.TryAddingContainerToStack(cooledContainer);

            // Act
            bool succes = cooledStack.TryAddingContainerToStack(cooledContainer);

            // Assert
            Assert.AreEqual(true, succes);
            Assert.AreEqual(2, cooledStack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStack_NormalContainerOnTopOfCooledContainer()
        {
            // Arrange
            ContainerStack cooledStack = new();
            cooledStack.TryAddingContainerToStack(cooledContainer);

            // Act
            bool succes = cooledStack.TryAddingContainerToStack(normalContainer);

            // Assert
            Assert.AreEqual(true, succes);
            Assert.AreEqual(2, cooledStack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStack_ValuableContainerOnTopOfCooledContainer()
        {
            // Arrange
            ContainerStack cooledStack = new();
            cooledStack.TryAddingContainerToStack(cooledContainer);

            // Act
            bool succes = cooledStack.TryAddingContainerToStack(valuableContainer);

            // Assert
            Assert.AreEqual(true, succes);
            Assert.AreEqual(2, cooledStack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStack_CooledValuableContainerOnTopOfCooledContainer()
        {
            // Arrange
            ContainerStack cooledStack = new();
            cooledStack.TryAddingContainerToStack(cooledContainer);

            // Act
            bool succes = cooledStack.TryAddingContainerToStack(cooledValuableContainer);

            // Assert
            Assert.AreEqual(true, succes);
            Assert.AreEqual(2, cooledStack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStack_NormalContainerOnTopOfNormalContainer()
        {
            // Arrange
            ContainerStack normalStack = new();
            normalStack.TryAddingContainerToStack(normalContainer);

            // Act
            bool succes = normalStack.TryAddingContainerToStack(normalContainer);

            // Assert
            Assert.AreEqual(true, succes);
            Assert.AreEqual(2, normalStack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStack_ValuableContainerOnTopOfNormalContainer()
        {
            // Arrange
            ContainerStack normalStack = new();
            normalStack.TryAddingContainerToStack(normalContainer);

            // Act
            bool succes = normalStack.TryAddingContainerToStack(valuableContainer);

            // Assert
            Assert.AreEqual(true, succes);
            Assert.AreEqual(2, normalStack.Containers.Count());
        }

        [TestMethod]
        public void TryAddingContainerToStack_AnyContainerOnTopOfValuableContainer()
        {
            // Arrange
            ContainerStack valuableStack = new();
            valuableStack.TryAddingContainerToStack(valuableContainer);

            // Act
            bool cooledSucces = valuableStack.TryAddingContainerToStack(cooledContainer);
            bool cooledValuableSucces = valuableStack.TryAddingContainerToStack(cooledValuableContainer);
            bool normalSucces = valuableStack.TryAddingContainerToStack(normalContainer);
            bool valuableSucces = valuableStack.TryAddingContainerToStack(valuableContainer);

            // Assert
            Assert.AreEqual(false, cooledSucces);
            Assert.AreEqual(false, cooledValuableSucces);
            Assert.AreEqual(false, normalSucces);
            Assert.AreEqual(false, valuableSucces);
            Assert.AreEqual(1, valuableStack.Containers.Count());
        }
        #endregion
    }
}
