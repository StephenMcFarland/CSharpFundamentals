using System;
using _04_Calculator_RepositoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Calculator_RepositoryPattern_Tests
{
    [TestClass]
    public class CalculatorRepository_Tests
    {
        [TestMethod]
        public void Calculator_AddTwoNumbers_ShouldBeCorrectValue()
        {
            //Arrange
            CalculatorRepository calcRepo = new CalculatorRepository();

            //Act
            int actualValue = calcRepo.AddTwoNumbers(4, 3);
            int expected = 7;
            //Assert
            Assert.AreEqual(expected, actualValue);
        }

        [TestMethod]
        public void Calculator_SubtractTwoNumbers_ShouldBeCorrectValue()
        {
            //Arrange
            CalculatorRepository calcRepo = new CalculatorRepository();

            //Act
            int actualValue = calcRepo.SubtractTwoNumbers(4, 3);
            int expected = 1;
            //Assert
            Assert.AreEqual(expected, actualValue);
        }

        [TestMethod]
        public void Calculator_DivideTwoNumbers_ShouldBeCorrectValue()
        {
            //Arrange
            CalculatorRepository calcRepo = new CalculatorRepository();

            //Act
            int actualValue = calcRepo.DivideTwoNumbers(9, 3);
            int expected = 3;
            //Assert
            Assert.AreEqual(expected, actualValue);
        }

        [TestMethod]
        public void Calculator_MultiplyTwoNumbers_ShouldBeCorrectValue()
        {
            //Arrange
            CalculatorRepository calcRepo = new CalculatorRepository();

            //Act
            int actualValue = calcRepo.MultiplyTwoNumbers(9, 3);
            int expected = 27;
            //Assert
            Assert.AreEqual(expected, actualValue);

        }
    }
}
