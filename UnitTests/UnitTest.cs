using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_AKVELON;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_PositiveNumbers()
        {
            int[] Array = new int[] { 1, 2, 4, 15, 3, 8, 5, 7, 6, 9, 0, 11 };
            int Max2nd = Program.FoundMax2nd(Array);
            
            int expected = 11;
            Assert.AreEqual(expected, Max2nd);
        }

        [TestMethod]
        public void Test_2IdenticalMaximumNumbers()
        {
            int[] Array = new int[] { 10, 48, 58, 97, 25, 4, 23, 4, 30, 86, 39, 45, 85, 11, 90, 24, 63, 85, 97, 72, 17, 49, 96, 11, 53, 46, 77, 71, 20, 19 };
            int Max2nd = Program.FoundMax2nd(Array);
            
            int expected = 97;
            Assert.AreEqual(expected, Max2nd);
        }

        [TestMethod]
        public void Test_NegativeNumbers()
        {
            int[] Array = new int[] { -15, -29, -12, -11, -25, -36, -3, -5, -5, -14, -9, -35, -17, -21, -12, -17, -24, -31, -4, -4 };
            int Max2nd = Program.FoundMax2nd(Array);

            int expected = -4;
            Assert.AreEqual(expected, Max2nd);
        }

        [TestMethod]
        public void Test_RandomArray()
        {
            int[] Array = new int[] { -9, 2, 5, -3, 7, -4, 5, -4, -1, -8, 5, 0, 10, 6, 5, -5, 4, 2, 5, -10 };
            int Max2nd = Program.FoundMax2nd(Array);

            int expected = 7;
            Assert.AreEqual(expected, Max2nd);
        }
    }
}
