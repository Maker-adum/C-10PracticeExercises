using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Add_WhenCalled_ReturnsSum()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(5, 3);

        // Assert
        Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void Subtract_WhenCalled_ReturnsDifference()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Subtract(10, 4);

        // Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void Multiply_WhenCalled_ReturnsProduct()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Multiply(6, 2);

        // Assert
        Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void Divide_WhenCalled_ReturnsQuotient()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        double result = calculator.Divide(15, 3);

        // Assert
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Divide_DivisionByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act & Assert
        Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
}