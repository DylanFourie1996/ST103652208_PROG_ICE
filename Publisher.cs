using System;

namespace ST10362208_ICETask1
{
    public class Publisher
    {
        public double Addition(double x, double y) => x + y;

        public double Subtract(double x, double y) => x - y;

        public double Multiply(double x, double y) => x * y;

        public double Divide(double x, double y)
        {
            // Check for negative values
            if (x < 0 || y < 0)
                throw new ArgumentOutOfRangeException("Both x and y must be non-negative.");

            // Check for division by zero
            if (y == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            // Perform and return the division
            return x / y;
        }
    }
}
