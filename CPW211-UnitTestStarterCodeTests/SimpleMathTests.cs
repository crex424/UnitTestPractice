using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange
            double expectedSum = num1 + num2;

            // Act
            double sum = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(5, 5)]
        [DataRow(0, 0)]
        [DataRow(1, 100)]
        [DataRow(2, 100)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method

            // Arrange
            double expectedProduct = num1 * num2;

            // Act
            double product = SimpleMath.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expectedProduct, product);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"

            // Arrange
            // do nothing

            // Act => Assert
            Assert.ThrowsException<ArgumentException>
                (() => SimpleMath.Divide(1, 0));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(6, 2)]
        [DataRow(100, 1)]
        [DataRow(75, 3)]
        public void Divide_TwoValidNumbers_ReturnsDividend(double num1, double num2)
        {
            // Arrange
            double expectedDividend = num1 / num2;
            // Act
            double dividend = SimpleMath.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expectedDividend, dividend);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(6, 2)]
        [DataRow(2, 2)]
        [DataRow(8, 2.5)]
        [DataRow(100, 50)]
        public void Subtract_TwoValidNumbers_ReturnsDifference(double num1, double num2)
        {
            // Arrange
            double expectedDifference = num1 - num2;
            // Act
            double difference = SimpleMath.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expectedDifference, difference);
        }
    }
}