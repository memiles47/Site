﻿namespace Site.App_Code
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
            return b == 0.0 ? 0.0 : a/b;
        }
    }
}