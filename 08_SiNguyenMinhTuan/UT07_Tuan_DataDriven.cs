using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT07_Tuan_DataDriven
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\DataUT07.csv", "DataUT07#csv",
           DataAccessMethod.Sequential), DeploymentItem("DataUT07.csv"), TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string arrayStr = TestContext.DataRow["array"].ToString();
            arrayStr = arrayStr.Trim('{', '}');
            int[] numbers = arrayStr.Split(';').Select(int.Parse).ToArray();
            int expectedMax = Convert.ToInt32(TestContext.DataRow["max"]);
            int actualMax = o.Largest(numbers);
            Console.WriteLine($"Array: {{{string.Join(", ", numbers)}}}, Expected Max: {expectedMax}, Actual Max: {actualMax}");
            Assert.AreEqual(expectedMax, actualMax);
        }
    }
}
