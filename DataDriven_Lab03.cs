using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUT03_TinhTienDien
{
    [TestClass]
    public class UTLab03_DataDriven
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\Data_Lab03.csv", // file CSV
            "Data_Lab03#csv",                  // tên table MSTest
            DataAccessMethod.Sequential)]
        [DeploymentItem("Data_Lab03.csv")]     
        public void TinhTienDien_Test()
        {
            int stt = Convert.ToInt32(TestContext.DataRow["STT"]);
            int chiSoCu = Convert.ToInt32(TestContext.DataRow["ChiSoCu"]);
            int chiSoMoi = Convert.ToInt32(TestContext.DataRow["ChiSoMoi"]);
            double expectedKW = Convert.ToDouble(TestContext.DataRow["ExpectedKW"]);

            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            double actualKW = obj.TinhTienDien(chiSoCu, chiSoMoi);

            // So sánh với round để tránh sai số double nhỏ
            Assert.AreEqual(Math.Round(expectedKW, 0), Math.Round(actualKW, 0),
                $"Test case {stt} failed. Expected={expectedKW}, Actual={actualKW}");
        }
    }
}
