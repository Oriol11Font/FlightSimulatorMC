using NUnit.Framework;
using UtilsMuchoCodigo;

namespace UtilsMuchoCodigo.UnitTest
{
    [TestFixture]
    public class HyperspaceTest
    {
        [TestCase(45.123, 8123.123)]
        [TestCase(23.123, 123.124)]
        public void CalculateVectorFromSituation_MultiplicationOver300_ExpectNull(double
            longitude, double latitude)
        {
            var situation = new Coordinates { Latitude = 23.123, Longitude = 123.124 };
            var vector = Hyperspace.CalculateVector(situation);

            Assert.That(vector, Is.Null);
        }

        [TestCase(3, 4, ExpectedResult = "C4")]
        [TestCase(4, 2, ExpectedResult = "D2")]
        public string ObtainCoordinate_MergeVector_ExpectCorrectResult(int posicioLletra,
            int numero)
        {
            var coordinate = Hyperspace.ObtainCoordinate(posicioLletra, numero);

            return coordinate;
        }

        [TestCase(19389174, 95612312, ExpectedResult = "B1")]
        [TestCase(5123123, 5657457, ExpectedResult = "D1")]
        [TestCase(1296045, 8756343, ExpectedResult = "B1")]
        [TestCase(6578124, 65809124, ExpectedResult = "D1")]
        [TestCase(41235, 52316, ExpectedResult = "A1")]
        [TestCase(870215, 798560, ExpectedResult = "D1")]
        [TestCase(127349, 96120, ExpectedResult = "A1")]
        public string CalculateVector_FromSituation_ExpectCorrectResult(double latitude, double
            longitude)
        {
            var situation = new Coordinates { Latitude = latitude, Longitude = longitude };

            var vector = Hyperspace.CalculateVector(situation);

            return vector;
        }
    }
}