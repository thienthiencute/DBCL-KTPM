using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUT02_GiaiPTBac2
{
    [TestClass]
    public class UTLab02
    {
        float x1, x2;
        MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestCase1_VoSoNghiem()
        {
            string result = obj.SolveQuadratic(0, 0, 0, out x1, out x2);
            Assert.AreEqual("Vô số nghiệm", result);
        }

        [TestMethod]
        public void TestCase2_VoNghiem()
        {
            string result = obj.SolveQuadratic(0, 0, 2, out x1, out x2);
            Assert.AreEqual("Vô nghiệm", result);
        }

        [TestMethod]
        public void TestCase3_VoNghiem()
        {
            string result = obj.SolveQuadratic(1, 2, 3, out x1, out x2);
            Assert.AreEqual("Vô nghiệm", result);
        }

        [TestMethod]
        public void TestCase4_Co1Nghiem()
        {
            string result = obj.SolveQuadratic(0, 6, 12, out x1, out x2);
            Assert.AreEqual("Có 1 nghiệm", result);
            Assert.AreEqual(-2f, x1); // nghiệm = -c/b = -12/6 = -2
        }

        [TestMethod]
        public void TestCase5_Co2Nghiem()
        {
            string result = obj.SolveQuadratic(1, -3, 2, out x1, out x2);
            Assert.AreEqual("Có 2 nghiệm phân biệt", result);
            Assert.AreEqual(1f, x1);
            Assert.AreEqual(2f, x2);
        }

        [TestMethod]
        public void TestCase6_CoNghiemKep()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            String actualResult = obj.SolveQuadratic(1, 2, 1, out x1, out x2);
            String expectedResult = "Có nghiệm kép";
            Assert.AreEqual(expectedResult, actualResult);


        }

    }
}
