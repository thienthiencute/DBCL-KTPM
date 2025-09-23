using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUT04_TimGiaTriKBeNhat
{
    [TestClass]
    public class UTLab04
    {
        [DataTestMethod]
        [DataRow(5, 6, 3)]    // s0, expected s, expected k
        [DataRow(-8, 0, 0)]
        [DataRow(1, 3, 2)]
        [DataRow(0, 1, 1)]
        public void SumTest(long s0, long expectedS, long expectedK)
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            long actualK = obj.Sum(s0, out long actualS);

            Assert.AreEqual(expectedK, actualK, $"Test with s0={s0} failed for k.");
            Assert.AreEqual(expectedS, actualS, $"Test with s0={s0} failed for s.");
        }
    }
}
