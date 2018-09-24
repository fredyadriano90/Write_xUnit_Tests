using Xunit;
using xStringCalculator.Models;

namespace xStringCalculator.ConstructorInitialization
{
    public class StringCalculatorShould
    {
        private readonly StringCalculator _sut;

        #region Constructor
        // this method is executed before each test
        // Each test method recive a new instance of _sut
        public StringCalculatorShould()
        {
            _sut = new StringCalculator();
        }
        #endregion

        #region Tests 

        [Fact]
        public void IsInt_25_ReturnsTrue()
        {
            // Given
            string number = "25";

            // When
            var actual = _sut.IsInt(number);

            // Then
            Assert.True(actual);
        }

        [Fact]
        public void IsInt_40_ReturnsTrue()
        {
            // Given
            string number = "40";

            // When
            var actual = _sut.IsInt(number);

            // Then
            Assert.True(actual);
        }

        [Fact]
        public void IsInt_a5_ReturnsFalse()
        {
            // Given
            string number = "a5";

            // When
            var actual = _sut.IsInt(number);

            // Then
            Assert.False(actual);
        }


        #endregion
    }
}