using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT_Lab08_Tuan_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\DataUT08.csv", "DataUT08#csv", DataAccessMethod.Sequential),
            DeploymentItem("DataUT08.csv"), TestMethod()]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string arrayStr = TestContext.DataRow[0].ToString();
            arrayStr = arrayStr.Trim('{', '}');
            int[] list = arrayStr.Length == 0
                ? Array.Empty<int>()
                : arrayStr.Split(';').Select(int.Parse).ToArray();

            int left = Convert.ToInt32(TestContext.DataRow[1]);
            int right = Convert.ToInt32(TestContext.DataRow[2]);

            string expected = TestContext.DataRow[3].ToString();
            expected = expected.Trim('{', '}');
            int[] expectedl = expected.Length == 0
                ? Array.Empty<int>()
                : expected.Split(';').Select(int.Parse).ToArray();

            o.QuickSort(list, left, right);

            string actualStr = string.Join(";", list);
            string expectedOut = string.Join(";", expectedl);

            Console.WriteLine($"Sorted: {actualStr}, Expected: {expectedOut}");
            Assert.AreEqual(expectedOut, actualStr);
        }
    }
}
