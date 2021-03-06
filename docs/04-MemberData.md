## Using member data
This is similar to [InlineData](./03-InlineData.md). 
Using this approach we can run the test using external data or create common data to be consumed for our tests avoid code duplication

```
namespace Test_Namespace
{
    public class StringCalculatorShould
    {
        private readonly StringCalculator _sut;

        public StringCalculatorShould() 
        {
            _sut = new StringCalculator();
        }

        [Theory]
        [MemberData(nameof(StringCalculatorTestData.Square), MemberType=typeof(StringCalculatorTestData))]
        public void Square_SingleNumer_ReturnsTheSquare(int square, float expected)
        {
            var actual = _sut.Square(square);

            Assert.Equals(expected, actual, 2);
        }

        ...... more tests 
    }
}

namespace TestData_Namespace
{
    public class StringCalculatorTestData
    {
        public static IEnumerable<object[]> Square
        {
            get 
            {
                yield return new object[] {25, 5};
                yield return new object[] {16, 4};
                yield return new object[] {9, 3};
            }
        }
    }
}
```
