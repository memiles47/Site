namespace Site
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a*b;
        }

        public double Divide(double a, double b)
        {
            //Divide by zero check
            return b == 0.0 ? 0.0 : a/b;
        }
    }
}