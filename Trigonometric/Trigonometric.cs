/*
Alec Hislop
P452289

PROGRAMMING III
Portfolio Activity 1.7 - Math Library

Contains classes for arithmetic, trigonometric and algebraic operations.
*/

using System;

namespace MathTrigonometry
{
    public class Trigonometric
    {
        // All functions have input as degrees.
        public static double Tan(double a)
        {
            double radians = a * (Math.PI / 180);
            double result = Math.Tan(radians);

            if (radians == Math.PI / 2)
                return Double.NaN;
            if (radians == -Math.PI / 2)
                return Double.NaN;
            return result;
        }

        public static double Sine(double a)
        {
            double radians = a * (Math.PI / 180);
            double result = Math.Sin(radians);

            if (radians == Math.PI / 2)
                return 1;
            if (radians == Math.PI)
                return 0;
            return result;
        }

        public static double Cosine(double a)
        {
            double radians = a * (Math.PI / 180);
            double result = Math.Cos(radians);

            if (radians == Math.PI / 2)
                return 0;
            if (radians == Math.PI)
                return -1;
            return result;
        }
    }
}
