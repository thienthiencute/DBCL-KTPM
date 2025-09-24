using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUT01_TimMax
{
    [TestClass]
    public class UTLab01
    {
        private MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

        // Test giá trị trả về bình thường
        private void TestMax(int a, int b, int c, int expected)
        {
            int actual = obj.Max(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        // Test ngoại lệ
        private void TestException(int a, int b, int c)
        {
            Assert.ThrowsException<IndexOutOfRangeException>(() => obj.Max(a, b, c));
        }

        // Thông thường
        [TestMethod] public void test01() => TestMax(16, 12, 8, 16);
        [TestMethod] public void test02() => TestMax(8, 16, 12, 16);
        [TestMethod] public void test03() => TestMax(12, 8, 16, 16);
        [TestMethod] public void test04() => TestMax(16, 16, 12, 16);
        [TestMethod] public void test05() => TestMax(16, 12, 16, 16);
        [TestMethod] public void test06() => TestMax(12, 16, 16, 16);
        [TestMethod] public void test07() => TestMax(16, 16, 16, 16);
        [TestMethod] public void test08() => TestMax(8, 8, 14, 14);
        [TestMethod] public void test09() => TestMax(8, 14, 8, 14);
        [TestMethod] public void test10() => TestMax(14, 8, 8, 14);

        // Ngoại lệ (out of range)
        [TestMethod] public void test11() => TestException(-10, 12, 8);
        [TestMethod] public void test12() => TestException(56, 12, 8);
        [TestMethod] public void test13() => TestException(16, -10, 8);
        [TestMethod] public void test14() => TestException(16, 56, 8);
        [TestMethod] public void test15() => TestException(16, 12, -10);
        [TestMethod] public void test16() => TestException(16, 12, 56);

        // Giá trị biên hợp lệ
        [TestMethod] public void test17() => TestMax(1, 1, 1, 1);
        [TestMethod] public void test18() => TestMax(50, 50, 50, 50);

        // Ngoại lệ biên
        [TestMethod] public void test19() => TestException(0, 12, 12);
        [TestMethod] public void test20() => TestException(51, 12, 12);
        [TestMethod] public void test21() => TestException(12, 0, 12);
        [TestMethod] public void test22() => TestException(12, 51, 12);
        [TestMethod] public void test23() => TestException(12, 12, 0);
        [TestMethod] public void test24() => TestException(12, 12, 51);
    }
}
