namespace Fibonacci
{
    public class FibonacciRecursive : IFibonacci
    {
        public double Calculate(int number)
        {
            if (number < 0)
                throw new System.ArgumentException("Argument should be positive");
            if (number < 2)
                return number;
            if (number > 51)
                throw new System.NotSupportedException("Calculation not supported");
            else
                return Calculate(number - 1) + Calculate(number - 2);
        }
    }
}