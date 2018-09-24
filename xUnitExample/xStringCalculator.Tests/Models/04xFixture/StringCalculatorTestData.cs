using System.Collections.Generic;

namespace xStringCalculator.xFixture
{
    public static class StringCalculatorTestData
    {
        // Using a property
        public static IEnumerable<object[]> IsInt_NumbersCorrect
        {
            get
            {
                yield return new object[] { "25" };
                yield return new object[] { "40" };
            }
        }

        // Using a method
        public static IEnumerable<object[]> IsInt_NumberInCorrect
        {
            get
            {
                yield return new object[] { "a5" };
                yield return new object[] { "8rf" };
            }
        }
    }
}