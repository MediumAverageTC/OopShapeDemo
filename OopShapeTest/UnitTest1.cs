using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OopShapeDemo;

namespace OopShapeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestCategory("Icosagon.cs")]

        [TestMethod]
        // Test Icosagons can calculate area correctly.
        public void IcosagonAreaTest()
        {
            Regular2DShape myShape = new Icosagon(5);
            double area = myShape.Area();
            Assert.AreEqual(789.22, Math.Round(area, 2, MidpointRounding.AwayFromZero)); // Google checker only does to 2 D.P.
        }

        [TestMethod]
        // Test Icosagons throw error when sent 0 as an arguement for length.
        public void IcosagonConstructorZeroTest()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Icosagon(0); }, "Shape did not throw expected arguement when zero passed to constructor.");
        }

        [TestMethod]
        // Test Icosagons throw error when sent a negative number as an arguement for length.
        public void IcosagonConstructorNegativeTest()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Icosagon(-1); }, "Shape did not throw expected arguement when negative value passed to constructor..");
        }
        [TestCategory("circle.cs")]
        [TestMethod]
        public void CircleAreaTest()
        {
            RegularShape2DShape myShape = new Circle(3);
            double area = myShape.area();
            Assert.AreEqual(28.27) Math.round(area, 2, MidpointRounding.AwayFromZero));

        [TestCategory("Hexagon.cs")]
        [TestMethod]
        // Test Icosagons can calculate area correctly.
        public void HexagonAreaTest()
        {
            Regular2DShape myShape = new Hexagon(5);
            double area = myShape.Area();
            Assert.AreEqual(64.95, Math.Round(area, 2, MidpointRounding.AwayFromZero)); // Google checker only does to 2 D.P.
        }
    }
}
