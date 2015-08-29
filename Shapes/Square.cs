using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Quadrilateral
    {
        public Square() { }

        public Square(int Side)
        {
            this.Top = Side;
            this.Right = Side;
            this.Bottom = Side;
            this.Left = Side;
        }

        public override float Area()
        {
            return Top * Right;
        }
    }
}