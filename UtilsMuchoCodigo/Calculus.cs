using System;
using System.Collections.Generic;
using System.Linq;

namespace UtilsMuchoCodigo
{
    public static class Calculus
    {
        public static int GetMcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        private static int Gcf(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public static int GetMcm(int a, int b) {
            return a / Gcf(a, b) * b;
        }

        public static int Add(params int[] nums)
        {
            return nums.Aggregate(0, (curr, next) => curr + next);
        }

        public static int Deduct(int a, int b)
        {
            return a - b;
        }

        public static int InverseDeduct(int a, int b)
        {
            return b - a;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b.Equals(0)) throw new DivideByZeroException();
            
            var division = (double) a / b;
            
            return Round(division);
        }

        public static int InverseDivide(int a, int b)
        {
            if (b.Equals(0)) throw new DivideByZeroException();

            var division = (double) b / a;

            return Round(division);
        }

        public static List<int> AllCalculus(int a, int b)
        {
            var sum = Add(a, b);
            var deduction = Deduct(a, b);
            var inverseDeduction = InverseDeduct(a, b);
            var multiplication = Multiply(a, b);
            var division = Divide(a, b);
            var inverseDivision = InverseDivide(a, b);

            return multiplication <= 300 ? 
                new List<int>
                {
                    sum, deduction, inverseDeduction, multiplication, division,
                    inverseDivision
                } 
                : 
                new List<int>();
        }

        private static int Round(double num) =>
            (int) Math.Round(num, MidpointRounding.AwayFromZero);
    }
}