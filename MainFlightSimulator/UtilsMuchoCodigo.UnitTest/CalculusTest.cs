using System.Collections.Generic;

namespace UtilsMuchoCodigo.UnitTest
{
    [TestFixture]
    public class CalculusTest
    {
        [TestCase(40, 16, ExpectedResult = 8)]
        [TestCase(30, 12, ExpectedResult = 6)]
        public int GetMcd_CalculateMcd_ExpectCorrectResult(int a, int b)
        {
            var mcd = Calculus.GetMcd(a, b);

            return mcd;
        }

        [TestCase(12, 8, ExpectedResult = 24)]
        [TestCase(180, 324, ExpectedResult = 1620)]
        public int GetMcm_CalculateMcm_ExpectCorrectResult(int a, int b)
        {
            var mcm = Calculus.GetMcm(a, b);

            return mcm;
        }

        [TestCase(89, 36, ExpectedResult = 125)]
        [TestCase(526, 93, 36, 74, ExpectedResult = 729)]
        [TestCase(921, 62, 47, 127, 134, ExpectedResult = 1291)]
        public int Add_AddNumbers_ExpectCorrectResult(params int[] nums)
        {
            var addedNumbers = Calculus.Add(nums);

            return addedNumbers;
        }

        [TestCase(79, 56, ExpectedResult = 23)]
        [TestCase(896, 452, ExpectedResult = 444)]
        [TestCase(53, 12, ExpectedResult = 41)]
        public int Deduct_DeductNumbers_ExpectCorrectResult(int a, int b)
        {
            var deductedNumbers = Calculus.Deduct(a, b);

            return deductedNumbers;
        }

        [TestCase(79, 56, ExpectedResult = -23)]
        [TestCase(896, 452, ExpectedResult = -444)]
        [TestCase(53, 12, ExpectedResult = -41)]
        public int InverseDeduct_InverseDeductNumbers_ExpectCorrectResult(int a, int b)
        {
            var inverseDeductResult = Calculus.InverseDeduct(a, b);

            return inverseDeductResult;
        }

        [TestCase(89, 26, ExpectedResult = 3)]
        [TestCase(593, 63, ExpectedResult = 9)]
        [TestCase(856, 36, ExpectedResult = 24)]
        public int Divide_DivideNumbers_ExpectCorrectResult(int a, int b)
        {
            var deductedNumbers = Calculus.Divide(a, b);

            return deductedNumbers;
        }

        [Test]
        public void Divide_DivideNumbers_ExpectDivideByZeroException()
        {
            Assert.That(() => Calculus.Divide(23, 0), Throws.Exception);
        }

        [TestCase(89, 26, ExpectedResult = 0)]
        [TestCase(9, 56, ExpectedResult = 6)]
        public int InverseDivide_InverseDivideNumbers_ExpectCorrectResult(int a, int b)
        {
            var deductedNumbers = Calculus.InverseDivide(a, b);

            return deductedNumbers;
        }

        [TestCase(59, 63, ExpectedResult = 3717)]
        [TestCase(92, 46, ExpectedResult = 4232)]
        [TestCase(3, 4, ExpectedResult = 12)]
        public int Multiply_MultiplyNumbers_ExpectCorrectResult(int a, int b)
        {
            var deductedNumbers = Calculus.Multiply(a, b);

            return deductedNumbers;
        }

        [Test]
        public void AllCalculus_CalculateAllMethods_ExpectCorrectResult()
        {
            var originalCalculus = new List<int> { 15, 5, -5, 50, 2, 1 };
            var calculus = Calculus.AllCalculus(10, 5);

            CollectionAssert.AreEqual(originalCalculus, calculus);
        }

        [Test]
        public void AllCalculus_CalculateAllMethodsMultiplicationOver300_ExpectEmptyList()
        {
            var calculus = Calculus.AllCalculus(30, 100);

            CollectionAssert.IsEmpty(calculus);
        }
    }
}