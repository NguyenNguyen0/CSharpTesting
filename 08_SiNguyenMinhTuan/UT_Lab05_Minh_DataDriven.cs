using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT_Lab05_Minh_DataDriven
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\DataUT05.csv", "DataUT05#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("DataUT05.csv"),
         TestMethod]
        public void TestMethod01()
        {
            var o = new MethodLibrary.MethodLibrary();

            string inputString = TestContext.DataRow[0]?.ToString() ?? string.Empty;
            int n = Convert.ToInt32(TestContext.DataRow[1]);
            int p = Convert.ToInt32(TestContext.DataRow[2]);
            string expectedOutput = TestContext.DataRow[3]?.ToString() ?? string.Empty;

            string actualOutput = o.HuyChuoi(inputString, n, p);

            Assert.AreEqual(expectedOutput, actualOutput,
                $"HuyChuoi(s='{inputString}', n={n}, p={p})");
        }
    }
}
