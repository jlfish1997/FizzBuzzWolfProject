using Xunit;

namespace FizzBuffWoofProject
{
    public class FizzBuzzWoofTests
    {
        [Fact]
        public void Number_Divisible_By_3()
        {
            //Arrange
            var number = 9;

            //Act
            bool divisibleBy3 = Program.CalculateIfNumberIsDivisble(number);

            //Assert
            Assert.True(divisibleBy3);
        }

        [Fact]
        public void Number_Divisible_By_5()
        {
            //Arrange
            var number = 15;

            //Act
            bool divisibleBy5 = Program.CalculateIfNumberIsDivisble(number);

            //Assert
            Assert.True(divisibleBy5);
        }

        [Fact]
        public void Number_Divisible_By_7()
        {
            //Arrange
            var number = 21;

            //Act
            bool divisibleBy5 = Program.CalculateIfNumberIsDivisble(number);

            //Assert
            Assert.True(divisibleBy5);
        }
    }
}
