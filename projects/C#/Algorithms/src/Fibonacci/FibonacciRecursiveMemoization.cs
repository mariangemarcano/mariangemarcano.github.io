namespace Fibonacci
{

    public class FibonacciRecursiveMemoization : IFibonacci
    {
        private double[] fibonacci = new double[0];
        public double Calculate(int number)
        {
            if (number < 0)
                throw new System.ArgumentException("Argument should be positive");
            if (number < 2)
                return number;
            if (fibonacci.Length == 0)
                fibonacci = new double[number + 1];
            return CalculateFibonacci(number);
        }

        private double CalculateFibonacci(int number)
        {
            if (fibonacci[number] > 0)
                return fibonacci[number];
            fibonacci[number - 1] = Calculate(number - 1);
            fibonacci[number - 2] = Calculate(number - 2);
            return fibonacci[number - 1] + fibonacci[number - 2];
        }
    }
}