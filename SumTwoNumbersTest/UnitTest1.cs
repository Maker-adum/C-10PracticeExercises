namespace SumTwoNumbersTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expectedSum = 15;

            var mathOp = new MathOperations();

            // Act
            int actualSum = mathOp.AddIntegers(a, b);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}