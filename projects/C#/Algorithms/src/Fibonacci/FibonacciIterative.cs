namespace Fibonacci
{
    public class FibonacciIterative : IFibonacci
    {
        public double Calculate(int number)
        {
            if (number < 0)
                throw new System.ArgumentException("Argument should be positive");
            if (number < 2)
                return number;
            var fib_n_2 = 0;
            var fib_n_1 = 1;
            var fib_n = 0;
            for (int i = 2; i <= number; i++)
            {
                fib_n = fib_n_1 + fib_n_2;
                fib_n_2 = fib_n_1;
                fib_n_1 = fib_n;
            }
            return fib_n;
        }
    }
}