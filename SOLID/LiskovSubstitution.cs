using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID
{
    class LiskovSubstitution
    {
    }



    public class AreaCalculator

    {
        public static int CalculateArea(Square s)
        {
            return s._height*s._height;
        }
        public static int CalculateArea(Rectangle r)
        {
            return r._height * r._width;
        }
    }

    public class Rectangle
    {
        public virtual  int _height { get; set; }
        public virtual int _width { get; set; }
    }

    public class Square : Rectangle
    {
        public override int _height
        {
            get
            {
                return base._height;
            }
            set
            {
                base._height = value;
                base._width = value;
            }
        }
        public override int _width
        {
            get
            {
                return base._width;
            }
            set
            {
                base._width = value;
                base._height = value;
            }
        }
    }


}
