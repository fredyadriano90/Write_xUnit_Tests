### Inline Data

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
        [InlineData(36, 6)]
        [InlineData(25, 5)]
        [InlineData(16, 4)]
        public void Square_SingleNumer_ReturnsTheSquare(int square, float expected)
        {
            var actual = _sut.Square(square);

            Assert.Equals(expected, actual, 2);
        }

        ...... more tests 
    }
}
```
