using Xunit;
using xStringCalculator.Models;
using System.Collections.Generic;

namespace xStringCalculator.xMemberData
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
        [MemberData(nameof(StringCalculatorTestData.IsInt_NumbersCorrect), MemberType = typeof(StringCalculatorTestData))]
        public void IsInt_25_ReturnsTrue(string number)
        {
            // When
            var actual = _sut.IsInt(number);

            //T hen
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(StringCalculatorTestData.IsInt_NumberInCorrect), MemberType = typeof(StringCalculatorTestData))]
        public void IsInt_a5_ReturnsFalse(string number)
        {
            // When
            var actual = _sut.IsInt(number);

            // Then
            Assert.False(actual);
        }


        #endregion
    }
}