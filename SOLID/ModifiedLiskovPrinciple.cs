using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID
{
    class ModifiedLiskovPrinciple
    {
    }

    public abstract class Shape
    {
        public  abstract int Area();
    }
    public class RectangleModified:Shape
    {
        public int _height { get; set; }
        public int _width { get; set; }
        public override int Area()
        {
            return _height*_width;
        }
    }

    public class SquareModified : Shape
    {
        public int _side { get; set; }
        public override int Area()
        {
            return _side*_side;
        }
    }
    
}
