using Xunit;

namespace xStringCalculator.xCollection
{
    [CollectionDefinition("StringCalculatorCollectionName")]
    public class StringCalculatorCollection : ICollectionFixture<StringCalculatorFixture> { }
}