using System.Diagnostics.CodeAnalysis;
using Xunit;
using Bogus;
using System;

namespace NewExercises.Domain.Tests
{
    [ExcludeFromCodeCoverage]
    public class RomanNumberTests
    {

        [Fact]

        public void ConvertIntegerToRoman_Numberrange_ConvertSuccessfully()
        {
            // Arrange
            var number = new Faker().Random.Int(1, 3999);
            var romanNumber = new RomanNumber();

            // Act
            romanNumber.ConvertIntegerToRoman(number);

            // Assert
            Assert.Equal(number, romanNumber);
        }

        [Fact]
        public void ConvertIntegerToRoman_NumberRange_MustBeAboveZero()
        {
            // Arrange
            var number = new Faker().Random.Int(-1000, 0);
            var romanNumber = new RomanNumber();

            // Act
            var exception = Assert.Throws<Exception>(() => romanNumber.ConvertIntegerToRoman(number));

            // Assert
            Assert.Equal("The number inserted is out of the limits", exception.Message);
        }

        public void ConvertIntegerToRoman_NumberRange_MustBeAbove4000()
        {
            // Arrange
            var number = new Faker().Random.Int(4000, 9000);
            var romanNumber = new RomanNumber();

            // Act
            var exception = Assert.Throws<Exception>(() => romanNumber.ConvertIntegerToRoman(number));

            // Assert
            Assert.Equal("The number inserted is out of the limits", exception.Message);
        }


    }
}
    



