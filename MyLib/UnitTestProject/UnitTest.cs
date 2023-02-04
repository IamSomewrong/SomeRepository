using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyLib;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodTriang()
        {
            Triangle tr1 = new Triangle(3, 4, 5);
            Assert.AreEqual(6, tr1.Area());
        }
        [TestMethod]
        public void TestMethodTriangIsRightTrue()
        {
            Triangle tr1 = new Triangle(3, 4, 5);
            Assert.AreEqual(true, tr1.IsRight);
        }
        [TestMethod]
        public void TestMethodTriangIsRightFalse()
        {
            Triangle tr1 = new Triangle(3, 4, 6);
            Assert.AreEqual(false, tr1.IsRight);
        }
        [TestMethod]
        public void TestMethodCircle()
        {
            Circle circ1 = new Circle(4);
            Assert.AreEqual(50, (int)circ1.Area());
        }
    }
}
