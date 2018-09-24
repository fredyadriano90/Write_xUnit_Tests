using Xunit;
using xStringCalculator.Models;

namespace xStringCalculator.xInlineData
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

        [Theory]
        [InlineData("25")]
        [InlineData("40")]
        public void IsInt_25_ReturnsTrue(string number)
        {
            //When
            var actual = _sut.IsInt(number);

            //Then
            Assert.True(actual);
        }

        [Theory]
        [InlineData("a5")]
        [InlineData("b8e")]
        public void IsInt_a5_ReturnsFalse(string number)
        {
            //When
            var actual = _sut.IsInt(number);

            //Then
            Assert.False(actual);
        }


        #endregion
    }
}