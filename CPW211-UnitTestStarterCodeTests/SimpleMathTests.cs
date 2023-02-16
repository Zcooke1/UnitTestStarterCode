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
            //Arrange
            // Use the DataRow values to test the Add method
            double sum = num1 + num2;

            //Act
            SimpleMath.Add(num1, num2);

            //Assert
            Assert.AreEqual(sum, SimpleMath.Add(num1,num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            //
            double product = num1 * num2;

            //Act
            SimpleMath.Multiply(num1, num2);


            //Assert
            // Use a few pairs of values to test the Multiply method
            Assert.AreEqual(product, SimpleMath.Multiply(num1, num2));
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            //Arrange
            double num1 = 5;
            double invalidDenominator = 0;

            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            //Assert => Act
            Assert.ThrowsException<ArgumentException>
                (() => SimpleMath.Divide(num1, invalidDenominator));
        }

        // TODO: Test Divide method with two valid numbers

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(3, 100)]
        [DataRow(5, 2)]
        public void Divide_UsingTwoValidNumbers_ReturnsQuotient(double num1, double num2)
        {
            //Arrange
            double quotient = num1 / num2;

            //Act
            SimpleMath.Divide(num1, num2);

            //Assert
            Assert.AreEqual(quotient, SimpleMath.Divide(num1, num2));

        }

        // TODO: Test subtract method with two valid numbers

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(3, -100)]
        [DataRow(-5, -2)]
        public void Subtract_UsingTwoValidNumbers_ReturnsDifference(double num1, double num2)
        {
            //Arrange
            double difference = num1 - num2;

            //Act
            SimpleMath.Subtract(num1, num2);

            //Assert
            Assert.AreEqual(difference, SimpleMath.Subtract(num1, num2));
        }
    }
}