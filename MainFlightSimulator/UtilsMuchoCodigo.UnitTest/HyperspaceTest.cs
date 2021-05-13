using NUnit.Framework;

namespace UtilsMuchoCodigo.UnitTest
{
    [TestFixture]
    public class HyperspaceTest
    {
        [TestCase(45.123, 8123.123, ExpectedResult = null)]
        [TestCase(23.123, 123.124, ExpectedResult = null)]
        public dynamic CalculateVectorFromSituation_MultiplicationOver300_ExpectNull(double
            longitude, double latitude)
        {
            var situation = new Coordinates {Latitude = 23.123, Longitude = 123.124};
            var vector = Hyperspace.CalculateVector(situation);

            return vector;
        }

        [TestCase(3, 4, ExpectedResult = "C4")]
        public string ObtainCoordinate_MergeVector_ExpectCorrectResult(int posicioLletra,
            int numero)
        {
            var coordinate = Hyperspace.ObtainCoordinate(posicioLletra, numero);

            return coordinate;
        }
    }
}