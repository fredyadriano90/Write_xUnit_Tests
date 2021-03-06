using Xunit;

namespace xStringCalculator.xFixture
{

    public class StringCalculatorShould : IClassFixture<StringCalculatorFixture>
    {
        private readonly StringCalculatorFixture _fixture;

        #region Constructor
        // this method is executed before each test
        // Each test method recive THE SAME instance of _sut
        public StringCalculatorShould(StringCalculatorFixture fixture)
        {
            _fixture = fixture;
        }
        #endregion

        #region Tests 

        [Theory]
        [MemberData(nameof(StringCalculatorTestData.IsInt_NumbersCorrect), MemberType = typeof(StringCalculatorTestData))]
        public void IsInt_25_ReturnsTrue(string number)
        {
            // When
            var actual = _fixture.Sut.IsInt(number);

            //T hen
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(StringCalculatorTestData.IsInt_NumberInCorrect), MemberType = typeof(StringCalculatorTestData))]
        public void IsInt_a5_ReturnsFalse(string number)
        {
            // When
            var actual = _fixture.Sut.IsInt(number);

            // Then
            Assert.False(actual);
        }


        #endregion
    }
}