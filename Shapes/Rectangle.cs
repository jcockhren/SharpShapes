using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
      {  
    public Rectangle() { }
    public Rectangle(float side1, float side2)
    {
        this.Top = side1;
        this.Right = side2;
        this.Bottom = side1;
        this.Left = side2;

    }
        public override float Area()
        {
            return Top * Right;
        }

    }
}
