using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT03_Nguyen_DataDriven
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\DataUT03.csv", "DataUT03#csv",
           DataAccessMethod.Sequential), DeploymentItem("DataUT03.csv"), TestMethod]
        public void TestMethod01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int tienDienCu = Convert.ToInt32(TestContext.DataRow[0]);
            int tienDienMoi = Convert.ToInt32(TestContext.DataRow[1]);
            double expectedResult = Convert.ToDouble(TestContext.DataRow[2]);
            double actualResult = o.TinhTienDien(tienDienCu, tienDienMoi);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}
