using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Quadrilateral : Shape
    {
        public float Top { get; set; }
        public float Bottom { get; set; }
        public float Left { get; set; }
        public float Right { get; set; }

        // Calls Shape's Constructor that provides default fill and border colors.
        public Quadrilateral() : base() {} 

        public Quadrilateral(float top, float bottom, float left, float right)
        {
        }

        public override float Perimeter()
        {
            if (Top == 0.0 || Bottom == 0.0 || Left == 0.0 || Right == 0.0)
            {
                throw new ArgumentException();
            } else
            {
                return Top + Bottom + Left + Right;
            }

        }


    }
}
