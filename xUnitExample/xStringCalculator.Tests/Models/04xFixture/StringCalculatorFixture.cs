using xStringCalculator.Models;
using System;

namespace xStringCalculator.xFixture
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