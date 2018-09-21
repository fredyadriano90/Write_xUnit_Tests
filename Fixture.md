## Getting the fixture through Dependency Injection
The SUT is created one time and used in all the tests 

```
namespace Fixtures_Namespace
{
    public class StringCalculatorFixture: IDisposable
    {
        public StringCalculator Sut {get; private set; }

        public StringCalculatorFixture()
        {
            Sut = new StringCalculator();
        }

        public void Dispose()
        {
            Sut.Dispose();
        }
    }
}

namespace Tests_Namespace
{
    public class StringCalculatorShould: IClassFixture<StringCalculatorFixture>
    {
        private readonly StringCalculatorFixture _fixture;

        public StringCalculatorShould(StringCalculatorFixture fixture) 
        {
            _fixture = fixture;
        }

        [Fact]
        public void Add_SingleNumer_ReturnsTheSame()
        {
            var expected = 5;

            var actual = _fixture.Sut.Add(expected);

            Assert.Equals(expected, actual);
        }

        [Fact]
        public void Square_SingleNumer_ReturnsTheSquare()
        {
            var input = 25;
            var expected = 5;

            var actual = _fixture.Sut.Add(expected);

            Assert.Equals(expected, actual);
        }

        ...... more tests 
    }
}
```
