namespace Fibonacci
{
    public class FibonacciSequenceIterative : IFibonacci
    {
        public double Calculate(int number)
        {
            if (number < 0)
                throw new System.ArgumentException("Argument should be positive");
            if (number < 2)
                return number;

            var fibonacci = new double[number + 1];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci[number];
        }
    }
}
