# Write xUnit Tests
[microsoft-unit-testing-best-practices](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)

### Naming your classes 
I like the test class name ending with **Test** or **Should**

I prefer **Should**, 
```
public class StringCalculatorShould
{
    [Fact]
    public void Add_SingleNumber_ReturnsSameNumber()
    {
        var sut = new StringCalculator();

        var actual = sut.Add("0");

        Assert.Equal(0, actual);
    }
}
```
The tests can be read, 
*The StringCalculator Should Add a SingleNumber and Returns the SameNumber.*

### Naming your methods 
Should consist in three parts

 - The name of the method being tested.
 - The scenario under which it's being tested.
 - The expected behavior when the scenario is invoked.
 
 ### Naming your system under test(sut)
 I like the idea of have an homogeneous name **sut**
