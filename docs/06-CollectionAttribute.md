### Collection Attribute

This is used to share the same object instance in two or more classess 

 1 - [Create a Fixture](./05-Fixture.md)
 
 2 - Create the collection fixture
 ```
 [CollectionDefinition("CollectionName")]
  public class CollectionFixtures : ICollectionFixture<StringCalculatorFixture> { }
  ```
  
  3- Consume the collection Fixture
  
  ```
  namespace Tests_Namespace
{
    [Collection("CollecitonName")]
    public class StringCalculatorShould
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
 
