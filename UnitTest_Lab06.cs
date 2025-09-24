using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUT06_ThayThe
{
    [TestClass]
    public class UTLab06
    {
        // Test case 1
        [TestMethod]
        public void TestCase01_VP()
        {
            string input = "Truong dh Cong Nghiep";
            string s1 = "dh";
            string s2 = "dai hoc";
            string expected = "Truong dai hoc Cong Nghiep";

            string result = ReplaceText(input, s1, s2);
            Assert.AreEqual(expected, result);
        }

        // Test case 2
        [TestMethod]
        public void TestCase02_IP()
        {
            string input = "";
            string s1 = "ab";
            string s2 = "Tr";
            string expected = "";

            string result = ReplaceText(input, s1, s2);
            Assert.AreEqual(expected, result);
        }

        // Test case 3
        [TestMethod]
        public void TestCase03_IP()
        {
            string input = "Truong dh Cong Nghiep";
            string s1 = "";
            string s2 = "Abc";
            string expected = "Truong dh Cong Nghiep";

            string result = ReplaceText(input, s1, s2);
            Assert.AreEqual(expected, result);
        }

        // Test case 4
        [TestMethod]
        public void TestCase04_IP()
        {
            string input = "Truong dh Cong Nghiep";
            string s1 = "dh";
            string s2 = "";
            string expected = "Truong Cong Nghiep";

            string result = ReplaceText(input, s1, s2);
            Assert.AreEqual(expected, result);
        }

        // Test case 5
        [TestMethod]
        public void TestCase05_IP()
        {
            string input = "";
            string s1 = "";
            string s2 = "";
            string expected = "";

            string result = ReplaceText(input, s1, s2);
            Assert.AreEqual(expected, result);
        }

        // Test case 6
        [TestMethod]
        public void TestCase06_IP()
        {
            string input = "Truong dh Cong Nghiep";
            string s1 = "kt";
            string s2 = "Dai hoc";
            string expected = "Truong dh Cong Nghiep";

            string result = ReplaceText(input, s1, s2);
            Assert.AreEqual(expected, result);
        }

        // Test case 7
        [TestMethod]
        public void TestCase07_VB()
        {
            string input = "abuong Dai hoc Cong Nghiep";
            string s1 = "ab";
            string s2 = "Tr";
            string expected = "Truong Dai hoc Cong Nghiep";

            string result = ReplaceText(input, s1, s2);
            Assert.AreEqual(expected, result);
        }

        // Test case 8
        [TestMethod]
        public void TestCase08_VB()
        {
            string input = "Truong Dai hoc Cong Nghiab";
            string s1 = "ab";
            string s2 = "ep";
            string expected = "Truong Dai hoc Cong Nghiep";

            string result = ReplaceText(input, s1, s2);
            Assert.AreEqual(expected, result);
        }

        // Test case 9
        [TestMethod]
        public void TestCase09_VB()
        {
            string input = "Truong dh Cong Nghiep";
            string s1 = "abc";
            string s2 = "";
            string expected = "Truong dh Cong Nghiep";

            string result = ReplaceText(input, s1, s2);
            Assert.AreEqual(expected, result);
        }

        // Hàm xử lý (giữ trong test class để chạy demo)
        private string ReplaceText(string input, string s1, string s2)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(s1))
                return input ?? "";
            return input.Replace(s1, s2);
        }
    }
}
