using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_SiNguyenMinhTuan
{
    [TestClass]
    public class UT06_Minh
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actual = o.ThayThe("", "", "");
            String expected = "";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actual = o.ThayThe("abcdef", "cd", "ss");
            String expected = "abssef";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actual = o.ThayThe("abcdef", "", "ss");
            String expected = "abssef";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actual = o.ThayThe("abcdef", "ss", "gh");
            String expected = "abcdef";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actual = o.ThayThe("abcdef", "cd", "");
            String expected = "abef";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actual = o.ThayThe("abc", "ab", "X");
            String expected = "Xc";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actual = o.ThayThe("abc", "cd", "D");
            String expected = "abD";
            Assert.AreEqual(expected, actual);
        }
    }
}
