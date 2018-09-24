using xStringCalculator.Models;
using System;

namespace xStringCalculator.xCollection
{
    public class StringCalculatorFixture : IDisposable
    {
        public StringCalculator Sut { get; private set; }

        public StringCalculatorFixture()
        {
            Sut = new StringCalculator();
        }

        public void Dispose()
        {
            // Something to dispose
        }
    }
}