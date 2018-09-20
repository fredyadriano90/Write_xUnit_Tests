## Setup the SUT in the constructor 
Each test method will receice a new SUT object to be tested.

```
public class StringCalculatorShould
{
    private readonly StringCalculator _sut;
    
    public StringCalculatorShould() 
    {
        _sut = new StringCalculator();
    }
    
    [Fact]
    public void Add_SingleNumer_ReturnsTheSame()
    {
        var expected = 5;
    
        var actual = _sut.Add(expected);
        
        Assert.Equals(expected, actual);
    }
    
    [Fact]
    public void Square_SingleNumer_ReturnsTheSquare()
    {
        var input = 25;
        var expected = 5;
    
        var actual = _sut.Add(expected);
        
        Assert.Equals(expected, actual);
    }
    
    ...... more tests 
}
```
