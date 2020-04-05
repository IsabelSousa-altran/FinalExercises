namespace NewExercise02.Domain.Tests
{
    using System.Diagnostics.CodeAnalysis;
    using Xunit;
    using Bogus;
    using System;

    [ExcludeFromCodeCoverage]
    public class Class1
    {
        private readonly Faker faker;
        public PerfectNumbers()
        {
            this.faker = new Faker();
        }

        [Fact]

        public void ItIsPerfectNumber_Numberrange_ConvertSuccessfully()
        {
            // Arrange
            var number = new Faker().Random.Int(1, 10000);

            // Act
            romanNumber.ConvertIntegerToRoman(number);

            // Assert
            Assert.Equal(number, romanNumber);
        }
    }
}
