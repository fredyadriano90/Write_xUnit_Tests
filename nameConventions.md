## Name conventions 

### Naming your classes 
Should consist in class' name to test ending **Should** or **Test**

I personaly prefer **Should** ending 

E.G. `public class MathematicShould {}`

### Naming your methods
Should consist in three parts

The name of the method being tested.
The scenario under which it's being tested.
The expected behavior when the scenario is invoked.

E.G. `public void Sum_TwoNumbers_ReturnsCorrectValue {}` 

### System under test (sut)
The majority of the times we must create an object's instance to test some behavior 

 E.G. If we are testing the class named `Mathematic` and the test need create an instance. 
 ```
 [Fact]
 public void Sum_TwoNumbers_ReturnsCorrectValue()
 {
    int exppected = 10;
    int number1 = 4;
    int number2 = 6;
    Mathematic mathematic = new Mathematic();
    
    int actual = mathematic.Sum(number1, number2);
    
    Assert.Equal(exppected, actual);
 }
 
 ** I prefer write the tests using the name sut instead of mathematic.
 [Fact]
 public void Sum_TwoNumbers_ReturnsCorrectValue()
 {
    int exppected = 10;
    int number1 = 4;
    int number2 = 6;
    Mathematic sut = new Mathematic();
    
    int actual = sut.Sum(number1, number2);
    
    int actual = sut.Sum(number1, number2);
    
    Assert.Equal(exppected, actual);
 }
 ```

### Test data
When I have to used `MembeDataAttribute`, I move the data to a new static class ending the name with `TestData` 
and I usually name the method or property equal that my test method.

E.G. `MathematicTestData`
     `Sum_TwoNumbers_ReturnsCorrectValue` or `Sum_TwoNumbers_ReturnsCorrectValue()`
