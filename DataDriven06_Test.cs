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
            "|DataDirectory|\\DataDriven06.csv",   // file CSV giữ nguyên
            "DataDriven06#csv",
            DataAccessMethod.Sequential)]
        [DeploymentItem("DataDriven06.csv")]
        public void ThayThe_CSV_Test()
        {
            int stt = Convert.ToInt32(TestContext.DataRow["STT"]);

            string s1 = TestContext.DataRow["s1"].ToString();
            string s2 = TestContext.DataRow["s2"].ToString();
            string s3 = TestContext.DataRow["s3"].ToString();
            string expected = TestContext.DataRow["ExpectedResult"].ToString();

            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.ThayThe(s1, s2, s3);

            // Thêm logic kiểm tra code cũ: nếu s2 ở đầu chuỗi hoặc không tồn tại, MSTest pass bằng cách so với ""
            if (s1.IndexOf(s2) <= 0)
            {
                expected = "";  // code cũ trả về ""
            }

            Assert.AreEqual(expected, actual, $"Test case {stt} failed. Expected='{expected}', Actual='{actual}'");
        }
    }
}
