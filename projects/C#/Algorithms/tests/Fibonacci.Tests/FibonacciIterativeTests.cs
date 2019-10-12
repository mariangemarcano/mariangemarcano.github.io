using Xunit;

namespace Fibonacci.Tests
{
    public class FibonacciIterativeTests
    {
        [Fact]
        public void Calculate_Negative_ThrowsException()
        {
            Assert.Throws<System.ArgumentException>(() => new FibonacciIterative().Calculate(-2));
        }

        [Fact]
        public void Calculate_0_ReturnsValue()
        {
            Assert.Equal(0, new FibonacciIterative().Calculate(0));
        }

        [Fact]
        public void Calculate_1_ReturnsValue()
        {
            Assert.Equal(1, new FibonacciIterative().Calculate(1));
        }

        [Fact]
        public void Calculate_20_ReturnsValue()
        {
            Assert.Equal(6765, new FibonacciIterative().Calculate(20));
        }

        [Fact]
        public void Calculate_40_ReturnsValue()
        {
            Assert.Equal(102334155, new FibonacciIterative().Calculate(40));
        }

    }

}
