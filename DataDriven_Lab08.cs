using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestUT08_QuickSort
{
    [TestClass]
    public class UTLab08_DataDriven
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DeploymentItem("Data_Lab08.csv")]
        [DataSource(
         "Microsoft.VisualStudio.TestTools.DataSource.CSV",
         "|DataDirectory|\\Data_Lab08.csv",
         "Data_Lab08#csv",
         DataAccessMethod.Sequential)]
        public void QuickSort_DataDriven()
        {
            string inputStr = TestContext.DataRow["Input"]?.ToString();
            string expectedStr = TestContext.DataRow["Expected"]?.ToString();
            int left = Convert.ToInt32(TestContext.DataRow["Left"]);
            int right = Convert.ToInt32(TestContext.DataRow["Right"]);

            int[] input = string.IsNullOrEmpty(inputStr)
                            ? new int[0]
                            : inputStr.Split(',').Select(int.Parse).ToArray();

            int[] expected = string.IsNullOrEmpty(expectedStr)
                            ? new int[0]
                            : expectedStr.Split(',').Select(int.Parse).ToArray();

            var methodLib = new MethodLibrary.MethodLibrary();

            // ✅ Trường hợp chỉ số thực sự sai: left < 0 hoặc right >= length → ném exception
            if (left < 0 || (input.Length > 0 && right >= input.Length))
            {
                Assert.ThrowsException<IndexOutOfRangeException>(
                    () => methodLib.QuickSort(input, left, right));
            }
            else
            {
                // Các trường hợp còn lại: mảng rỗng, left > right, left == right
                // QuickSort chỉ return, không ném exception
                methodLib.QuickSort(input, left, right);

                string actualStr = string.Join(",", input);
                string expectedStr2 = string.Join(",", expected);

                Assert.AreEqual(expectedStr2, actualStr);
            }
        }
    }
}
