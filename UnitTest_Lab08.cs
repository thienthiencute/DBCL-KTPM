using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUT08_QuickSort
{
    [TestClass]
    public class UTLab08
    {
        [TestMethod]
        public void testQuickSort01()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] arr = { 5, 3, 8, 1, 2 };
            int[] expectResult = { 1, 2, 3, 5, 8 };
            obj.QuickSort(arr, 0, 4);
            CollectionAssert.AreEqual(expectResult, arr);
        }

        [TestMethod]
        public void testQuickSort02()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] arr = { };
            int[] expectResult = { };
            obj.QuickSort(arr, 0, 0);
            CollectionAssert.AreEqual(expectResult, arr);
        }

        [TestMethod]
        public void exceptionQuickSort03()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                int[] arr = { 5, 3, 8, 1, 2 };
                obj.QuickSort(arr, -2, 5);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void testQuickSort04()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] arr = { 5, 3, 8, 1, 2 };
            int[] expectResult = { 5, 3, 8, 1, 2 }; // không thay đổi
            obj.QuickSort(arr, 7, 4);
            CollectionAssert.AreEqual(expectResult, arr);
        }

        [TestMethod]
        public void exceptionQuickSort05()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                int[] arr = { 5, 3, 8, 1, 2 };
                obj.QuickSort(arr, 1, 9);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void testQuickSort06()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] arr = { int.MinValue, 3, 8, 1, 2 };
            int[] expectResult = { int.MinValue, 1, 2, 3, 8 };
            obj.QuickSort(arr, 1, 4);
            CollectionAssert.AreEqual(expectResult, arr);
        }

        [TestMethod]
        public void testQuickSort07()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] arr = { int.MaxValue, 3, 8, 1, 2 };
            int[] expectResult = { 1, 2, 3, 8, int.MaxValue };
            obj.QuickSort(arr, 0, 4);
            CollectionAssert.AreEqual(expectResult, arr);
        }

        [TestMethod]
        public void testQuickSort08()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] arr = { 8, 7, 5, 3, 2 };
            int[] expectResult = { 3, 5, 7, 8, 2 };
            obj.QuickSort(arr, 0, 3);
            CollectionAssert.AreEqual(expectResult, arr);
        }

        [TestMethod]
        public void testQuickSort09()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] arr = { 8, 7, 5, 3, 2 };
            int[] expectResult = { 8, 7, 5, 2, 3 };
            obj.QuickSort(arr, 3, 4);
            CollectionAssert.AreEqual(expectResult, arr);
        }

        [TestMethod]
        public void testQuickSort10()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] arr = { 8, 7, 5, 3, 2 };
            int[] expectResult = { 8, 7, 2, 3, 5 };
            obj.QuickSort(arr, 2, 4);
            CollectionAssert.AreEqual(expectResult, arr);
        }

        [TestMethod]
        public void exceptionQuickSort11()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                int[] arr = { 3, 8, 6, 4, 2, 1 };
                obj.QuickSort(arr, -1, 3);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void testQuickSort12()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] arr = { 3, 8, 6, 4, 2, 1 };
            int[] expectResult = { 3, 8, 6, 4, 2, 1 }; // không thay đổi vì left=right
            obj.QuickSort(arr, 1, 1);
            CollectionAssert.AreEqual(expectResult, arr);
        }

        [TestMethod]
        public void exceptionQuickSort13()
        {
            Exception expectedException = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
                int[] arr = {  5, 3, 8, 1, 2  };
                obj.QuickSort(arr, 3, 5);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
    }
}
