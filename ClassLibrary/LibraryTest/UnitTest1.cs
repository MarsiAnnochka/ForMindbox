using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace LibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRound()
        {
            double result = Figure.Round(5.8);
            Assert.AreEqual(52.842, result, 0.001, 
                string.Format("Radius: 5.8\n Expected: 52.842\n Actual: {0}\n", result));
        }

        [TestMethod]
        public void TestErrorRound()
        {
            double result;
            Assert.ThrowsException<Exception>(() => result = Figure.Round(-5.8), 
                "Radius: -5.8\n Expected: Error\n Actual: No exception or other type\n");
        }

        [TestMethod]
        public void TestTriangle()
        {
            double result = Figure.Triangle(5.8, 10.4, 12);
            Assert.AreEqual(30.155, result, 0.001,
                string.Format("Edges: 5.8, 10.4, 12\n Expected: 30.155\n Actual: {0}\n", result));
        }

        [TestMethod]
        public void TestErrorTriangle()
        {
            double result;
            Assert.ThrowsException<Exception>(() => result = Figure.Triangle(5.8, 10.4, 1), 
                "Edges: 5.8, 10.4, 1\n Expected: Error\n Actual: No exception or other type\n");
        }

        [TestMethod]
        public void TestRightTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRight(),
                string.Format("Edges: 3, 4, 5\n Expected: true\n Actual: false\n"));
        }

        [TestMethod]
        public void TestNotRightTriangle()
        {
            Triangle triangle = new Triangle(3, 4.5, 5);
            Assert.IsFalse(triangle.IsRight(),
                string.Format("Edges: 3, 4.5, 5\n Expected: false\n Actual: true\n"));
        }
    }
}
