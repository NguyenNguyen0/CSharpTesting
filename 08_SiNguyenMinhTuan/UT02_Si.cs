using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT02_Si
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String ExpectedResult = "Vô số nghiệm";
            float ExpectedX1 = float.NaN, ExpectedX2 = float.NaN;
            float ActualX1, ActualX2;
            String ActualResult = o.SolveQuadratic(0, 0, 0, out ActualX1, out ActualX2);
            Assert.AreEqual(ExpectedResult, ActualResult);
            Assert.AreEqual(ExpectedX1, ActualX1);
            Assert.AreEqual(ExpectedX2, ActualX2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String ExpectedResult = "Vô nghiệm";
            float ExpectedX1 = float.NaN, ExpectedX2 = float.NaN;
            float ActualX1, ActualX2;
            String ActualResult = o.SolveQuadratic(0, 0, 300, out ActualX1, out ActualX2);
            Assert.AreEqual(ExpectedResult, ActualResult);
            Assert.AreEqual(ExpectedX1, ActualX1);
            Assert.AreEqual(ExpectedX2, ActualX2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String ExpectedResult = "Có 1 nghiệm";
            float ExpectedX1 = 2, ExpectedX2 = 2;
            float ActualX1, ActualX2;
            String ActualResult = o.SolveQuadratic(0, 2, -4, out ActualX1, out ActualX2);
            Assert.AreEqual(ExpectedResult, ActualResult);
            Assert.AreEqual(ExpectedX1, ActualX1, 0.001);
            Assert.AreEqual(ExpectedX2, ActualX2);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String ExpectedResult = "Có 2 nghiệm phân biệt";
            float ExpectedX1 = 1, ExpectedX2 = 2;
            float ActualX1, ActualX2;
            String ActualResult = o.SolveQuadratic(1, -3, 2, out ActualX1, out ActualX2);
            Assert.AreEqual(ExpectedResult, ActualResult);
            Assert.AreEqual(ExpectedX1, ActualX1, 0.001);
            Assert.AreEqual(ExpectedX2, ActualX2, 0.001);
        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String ExpectedResult = "Có nghiệm kép";
            float ExpectedX1 = 2, ExpectedX2 = 2;
            float ActualX1, ActualX2;
            String ActualResult = o.SolveQuadratic(1, -4, 4, out ActualX1, out ActualX2);
            Assert.AreEqual(ExpectedResult, ActualResult);
            Assert.AreEqual(ExpectedX1, ActualX1, 0.001);
            Assert.AreEqual(ExpectedX2, ActualX2, 0.001);
        }
    }
}
