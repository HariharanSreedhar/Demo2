using Demo1;

namespace Demo1Test_2
{
    public class UnitTest1
    {

        [Fact]
        public void TwoInput_Addition_AddedResult()
        {
            // Arrange
            float input1 = 5;
            float input2 = 5;
            float expectedAnswer = 10;
            Calculator calci = new Calculator();

            // Act
            var answer = calci.Addition(input1, input2);

            // Assert
            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void TwoInput_Subtraction_SutractedResult()
        {
            // Arrange
            float input1 = 10;
            float input2 = 5;
            float expectedAnswer = 5;
            Calculator calci = new Calculator();

            // Act
            var answer = calci.Subtraction(input1, input2);

            // Assert
            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void TwoInput_Multiplication_MultipliedResult()
        {
            // Arrange
            float x = 10;
            float y = 10;
            float expectedAnswer = 100;
            Calculator calci = new Calculator();

            // Act
            var answer = calci.Multiplication(x, y);

            // Assert
            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void TwoInput_Division_DividedResult()
        {
            // Arrange
            float x = 20;
            float y = 5;
            float expectedAnswer = 4;
            Calculator calci = new Calculator();

            // Act
            var answer = calci.Division(x, y);

            // Assert
            Assert.Equal(expectedAnswer, answer);
        }
    }
}