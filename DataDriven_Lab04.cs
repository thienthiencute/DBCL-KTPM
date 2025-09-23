using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUT04_TimGiaTriKBeNhat
{
    [TestClass]
    public class UTLab04_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\Data_Lab04.csv", "Data_Lab04#csv", DataAccessMethod.Sequential),
        DeploymentItem("Data_Lab04.csv"), TestMethod]
        public void SumTest()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int s0 = Int32.Parse(TestContext.DataRow[0].ToString());
            long actual = obj.Sum(s0, out long s);

            long expected = Int32.Parse(TestContext.DataRow[2].ToString());
            Assert.AreEqual(expected, actual);

        }
    }
}
