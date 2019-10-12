using Xunit;

namespace Fibonacci.Tests
{
    public class FibonacciRecursiveTests
    {
        [Fact]
        public void Calculate_Negative_ThrowsException()
        {
            Assert.Throws<System.ArgumentException>(() => new FibonacciRecursive().Calculate(-2));
        }

        [Fact]
        public void Calculate_0_ReturnsValue()
        {
            Assert.Equal(0, new FibonacciRecursive().Calculate(0));
        }

        [Fact]
        public void Calculate_1_ReturnsValue()
        {
            Assert.Equal(1, new FibonacciRecursive().Calculate(1));
        }

        [Fact]
        public void Calculate_Input_20_ReturnsValue()
        {
            Assert.Equal(6765, new FibonacciRecursive().Calculate(20));
        }

        [Fact]
        public void Calculate_Input_40_ReturnsValue()
        {
            Assert.Equal(102334155, new FibonacciRecursive().Calculate(40));
        }

    }
}
