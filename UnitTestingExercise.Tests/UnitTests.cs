using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(10, 20, 30, 60)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();

            //Act
            var actual = sut.AddMethod(num1, num2, num3);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(12, 8, 4)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();

            //Act
            var actual = sut.SubtractMethod(minuend, subtrhend);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(5, 4, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();

            //Act
            var actual = sut.MultiMethod(num1, num2);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(20, 5, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();

            //Act
            var actual = sut.DivideMethod(num1, num2);

            //Assert
            Assert.Equal(actual, expected);

        }

        [Fact]
        public void CheckFactor()
        {
            //Arrange
            var sut = new UnitTestMethods();
            int num1 = 12;
            int num2 = 3;
            string expected = "They factor into each other!";
            //Act
            var actual = sut.FactorTest(num1, num2);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void EvenOrOddMethod()
        {
            //Arrange
            var sut = new UnitTestMethods();
            int num = 8;
            string expected = "It is even!";

            //Act
            var actual = sut.EvenOrOdd(num);

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
