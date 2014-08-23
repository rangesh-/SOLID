using System.Collections.Generic;
using SOLID;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{


    /// <summary>
    ///This is a test class for CalculateAreaTestTest and is intended
    ///to contain all CalculateAreaTestTest Unit Tests
    ///</summary>
    /// 
    [TestClass]
    public class CalculateAreaTest
    {
        [TestMethod]
        public void SixFor3x2Rectangle()
        {
            var result = new Rectangle{_height =3,_width = 2};
            Assert.AreEqual(6,AreaCalculator.CalculateArea(result));
        }

        [TestMethod]
        public void fourForSquare()
        {
            var result = new Square { _height = 4};
            Assert.AreEqual(16, AreaCalculator.CalculateArea(result));
        }

       // [TestMethod]
        //public void TwentyFor5x4RectangleFromSquare()
        //{
        //    Rectangle R=new Square();
        //    R._height = 5;
        //    R._width = 4;
        //    Assert.AreEqual(20,AreaCalculator.CalculateArea(R));
        //}

        ////////////Modified Test Case After Applying the LiskovPrinciple
        [TestMethod]
        public void NineFor3x3Rectangle()
        {
            var result = new RectangleModified() { _height = 3, _width = 2 };
            Assert.AreEqual(6, result.Area());
        }
        [TestMethod]
        public void TwentyFor5x5Square()
        {
            var result = new SquareModified() { _side = 5};
            Assert.AreEqual(25, result.Area());
        }
        [TestMethod]
        public void CombineSquareandRectangle()
        {
List<Shape> result=new List<Shape>()
{
    
    new RectangleModified(){_height =4,_width =5},
    new SquareModified(){_side =4}
};
            var area = new List<int>();
            foreach (var shape in result)
            {
              area.Add(shape.Area());
            }
            Assert.AreEqual(20,area[0]);
            Assert.AreEqual(16,area[1]);
        }


    }
}
