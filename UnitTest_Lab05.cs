using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUT05_HuyChuoi
{
    [TestClass]
    public class UTLab05
    {
        [TestMethod]
        public void TestCase01()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 3, 2);
            string expected = "thhihi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase02()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 3, 20);
            string expected = "thien hihi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase03()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 3, -5);
            string expected = "thien hihi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase04()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 20, 1);
            string expected = "t";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase05()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", -4, 1);
            string expected = "thien hihi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase06()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 2, 0);
            string expected = "ien hihi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase07()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 1, 8);
            string expected = "thien hi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase08()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 0, 5);
            string expected = "thien hihi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase09()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 4, 5);
            string expected = "thien";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase10()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 2, -1);
            string expected = "thien hihi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase11()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 2, 15);
            string expected = "thien hihi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase12()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", -1, 0);
            string expected = "thien hihi";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase13()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("thien hihi", 20, 3);
            string expected = "thi";
            Assert.AreEqual(expected, actual);
        }
    }
}
