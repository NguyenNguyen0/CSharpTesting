using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT05_Minh_DataDriven
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\DataUT05.csv", "DataUT05#csv",
           DataAccessMethod.Sequential), DeploymentItem("DataUT05.csv"), TestMethod]
        public void TestMethod01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string inputString = TestContext.DataRow["s"].ToString();
            int n = Convert.ToInt32(TestContext.DataRow["n"]);
            int p = Convert.ToInt32(TestContext.DataRow["p"]);
            string expectedOutput = TestContext.DataRow["output"].ToString();

            string actualOutput = o.HuyChuoi(inputString, n, p);

            Assert.AreEqual(expectedOutput, actualOutput,
                $"HuyChuoi failed with s='{inputString}', n={n}, p={p}. Expected: '{expectedOutput}', Actual: '{actualOutput}'");
        }
    }
}
