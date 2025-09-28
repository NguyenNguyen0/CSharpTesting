using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT_Lab01_Si
    {
        MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

        // VALID PARTITIONS 
        [TestMethod] public void TestMethod01() { Assert.AreEqual(10, methodLibrary.Max(10, 5, 6)); }
        [TestMethod] public void TestMethod02() { Assert.AreEqual(9, methodLibrary.Max(7, 9, 8)); }
        [TestMethod] public void TestMethod03() { Assert.AreEqual(10, methodLibrary.Max(5, 8, 10)); }
        [TestMethod] public void TestMethod04() { Assert.AreEqual(12, methodLibrary.Max(12, 8, 10)); }
        [TestMethod] public void TestMethod05() { Assert.AreEqual(12, methodLibrary.Max(10, 12, 10)); }
        [TestMethod] public void TestMethod06() { Assert.AreEqual(10, methodLibrary.Max(8, 10, 10)); }
        [TestMethod] public void TestMethod07() { Assert.AreEqual(12, methodLibrary.Max(12, 12, 12)); }

        //  INVALID PARTITIONS 
        [TestMethod] public void TestMethod08() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(-5, 9, 8)); }
        [TestMethod] public void TestMethod09() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(70, 9, 8)); }
        [TestMethod] public void TestMethod10() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(7, -10, 8)); }
        [TestMethod] public void TestMethod11() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(7, 100, 8)); }
        [TestMethod] public void TestMethod12() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(7, 9, -22)); }
        [TestMethod] public void TestMethod13() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(7, 9, 52)); }

        //  VALID BOUNDARY 
        [TestMethod] public void TestMethod14() { Assert.AreEqual(0, methodLibrary.Max(0, 0, 0)); }
        [TestMethod] public void TestMethod15() { Assert.AreEqual(50, methodLibrary.Max(50, 50, 50)); }

        // INVALID BOUNDARY
        [TestMethod] public void TestMethod16() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(-1, 0, 5)); }
        [TestMethod] public void TestMethod17() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(51, 5, 6)); }
        [TestMethod] public void TestMethod18() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(10, -1, 6)); }
        [TestMethod] public void TestMethod19() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(10, 51, 6)); }
        [TestMethod] public void TestMethod20() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(10, 5, -1)); }
        [TestMethod] public void TestMethod21() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(10, 5, 51)); }
    }
}