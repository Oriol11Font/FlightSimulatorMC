using System;
using System.Collections;
using System.Linq;

namespace UtilsMuchoCodigo
{
    public static class Hyperspace
    {
        public static string CalculateVector()
        {
            var rnd = new Random();

            return ObtainCoordinate(rnd.Next(1, 6), rnd.Next(1, 5));
        }

        public static string CalculateVector(Coordinates situation)
        {
            var nums = new[] {13, 11, 7, 5, 3, 2};
            var longitude = nums.Aggregate(.0,
                (a, b) => a + situation.Longitude % b);
            var latitude = nums.Aggregate(.0,
                (a, b) => a + situation.Latitude % b);

            var mcm = Calculus.GetMcm((int) longitude, (int) latitude);
            var gcd = Calculus.GetMcd((int) longitude, (int) latitude);

            var calculus = Calculus.AllCalculus(mcm, gcd);

            if (calculus is {Count: 0})
                return null;

            var posicioLletra = (calculus[0] + calculus[1] + calculus[2]) % 6;
            var posicioNumero = (calculus[3] + calculus[4] + calculus[5]) % 5 + 1;

            return ObtainCoordinate(posicioLletra, posicioNumero);
        }

        public static string ObtainCoordinate(int posicioLletra, int posicioNumero)
        {
            var chars = new ArrayList {'A', 'B', 'C', 'D', 'E', 'F'};

            return $"{chars[posicioLletra - 1]}{posicioNumero.ToString()}";
        }
    }
}