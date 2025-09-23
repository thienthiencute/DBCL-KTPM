using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUT01_TimMax
{
    [TestClass]
    public class UTLab01_DataDriven
    {
        // Bắt buộc khai báo TestContext để dùng DataSource
        public TestContext TestContext { get; set; }

        // Dùng DataSource + DeploymentItem đúng cú pháp
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\Data_Lab01.csv", "Data_Lab01#csv", DataAccessMethod.Sequential)]
        [DeploymentItem("Data_Lab01.csv")]
        public void TestMultiply()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string check = TestContext.DataRow[4].ToString();

            int a = Int32.Parse(TestContext.DataRow[0].ToString());
            int b = Int32.Parse(TestContext.DataRow[1].ToString());
            int c = Int32.Parse(TestContext.DataRow[2].ToString());

            if (check == "none")
            {
                int expectedResult = Int32.Parse(TestContext.DataRow[3].ToString());
                int actualResult = obj.Max(a, b, c);
                Assert.AreEqual(expectedResult, actualResult);
            }
            else if (check == "exception")
            {
                Exception expectedResult = null;
                try
                {
                    int actualResult = obj.Max(a, b, c);
                }
                catch (IndexOutOfRangeException ex)
                {
                    expectedResult = ex;
                }
                Assert.IsNotNull(expectedResult);
            }
        }
    }
}
