using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT04_Nguyen
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long SumExpected = 10;
            long KExpected = 4;
            long SumActual;
            long KActual = o.Sum(7, out SumActual);

            Assert.AreEqual(SumExpected, SumActual);
            Assert.AreEqual(KExpected, KActual);
        }
    }
}
