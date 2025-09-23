using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUT06_ThayThe
{
    [TestClass]
    public class UTLab06_DataDriven
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\Data_Lab06.csv",
            "Data_Lab06#csv",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Data_Lab06.csv")]
        public void ThayThe()
        {
            int stt = Convert.ToInt32(TestContext.DataRow["STT"]);

            string s1 = TestContext.DataRow["s1"]?.ToString() ?? "";
            string s2 = TestContext.DataRow["s2"]?.ToString() ?? "";
            string s3 = TestContext.DataRow["s3"]?.ToString() ?? "";
            string expected = TestContext.DataRow["ExpectedResult"]?.ToString() ?? "";

            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.ThayThe(s1, s2, s3);

            // So sánh trực tiếp với CSV
            Assert.AreEqual(expected, actual,
                $"Test case {stt} failed. Expected='{expected}', Actual='{actual}'");
        }
    }
}
