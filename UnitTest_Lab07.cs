using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUT07_Largest
{
    [TestClass]
    public class UTLab07
    {
        MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void Test01_VP()
        {
            int[] a = { 1, 2, 3, 4 };
            int expected = 4;
            int actual = obj.Largest(a);
            Assert.AreEqual(expected, actual, "VP: Max của {1,2,3,4} phải là 4");
        }

        [TestMethod]
        public void Test02_VB()
        {
            int[] a = { 1, 2, -2147483648 };
            int expected = 2;
            int actual = obj.Largest(a);
            Assert.AreEqual(expected, actual, "VB: Max của {1,2,MIN} phải là 2");
        }

        [TestMethod]
        public void Test03_VB_Max()
        {
            int[] a = { 1, 2, 2147483647 };
            int expected = 2147483647;
            int actual = obj.Largest(a);
            Assert.AreEqual(expected, actual, "VB: Max của {1,2,MAX} phải là MAX");
        }

        [TestMethod]
        public void Test04_IB_Empty()
        {
            int[] a = { };
            int expected = 2147483647; // theo yêu cầu
            int actual = obj.Largest(a);
            Assert.AreEqual(expected, actual, "IB: Mảng rỗng trả về MAX");
        }
    }
}
