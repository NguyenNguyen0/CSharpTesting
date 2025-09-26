using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT01_Si
    {
        MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

        // VALID PARTITIONS 
        [TestMethod] public void TestCase01() { Assert.AreEqual(10, methodLibrary.Max(10, 5, 6)); }
        [TestMethod] public void TestCase02() { Assert.AreEqual(9, methodLibrary.Max(7, 9, 8)); }
        [TestMethod] public void TestCase03() { Assert.AreEqual(10, methodLibrary.Max(5, 8, 10)); }
        [TestMethod] public void TestCase04() { Assert.AreEqual(12, methodLibrary.Max(12, 8, 10)); }
        [TestMethod] public void TestCase05() { Assert.AreEqual(12, methodLibrary.Max(10, 12, 10)); }
        [TestMethod] public void TestCase06() { Assert.AreEqual(10, methodLibrary.Max(8, 10, 10)); }
        [TestMethod] public void TestCase07() { Assert.AreEqual(12, methodLibrary.Max(12, 12, 12)); }

        //  INVALID PARTITIONS 
        [TestMethod] public void TestCase08() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(-5, 9, 8)); }
        [TestMethod] public void TestCase09() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(70, 9, 8)); }
        [TestMethod] public void TestCase10() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(7, -10, 8)); }
        [TestMethod] public void TestCase11() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(7, 100, 8)); }
        [TestMethod] public void TestCase12() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(7, 9, -22)); }
        [TestMethod] public void TestCase13() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(7, 9, 52)); }

        //  VALID BOUNDARY 
        [TestMethod] public void TestCase14() { Assert.AreEqual(0, methodLibrary.Max(0, 0, 0)); }
        [TestMethod] public void TestCase15() { Assert.AreEqual(50, methodLibrary.Max(50, 50, 50)); }

        // INVALID BOUNDARY
        [TestMethod] public void TestCase16() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(-1, 0, 5)); }
        [TestMethod] public void TestCase17() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(51, 5, 6)); }
        [TestMethod] public void TestCase18() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(10, -1, 6)); }
        [TestMethod] public void TestCase19() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(10, 51, 6)); }
        [TestMethod] public void TestCase20() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(10, 5, -1)); }
        [TestMethod] public void TestCase21() { Assert.ThrowsException<IndexOutOfRangeException>(() => methodLibrary.Max(10, 5, 51)); }
    }
}