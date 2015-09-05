using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(float width, float height) : base(width,width,height,height)
        {

        }

        /// <summary>
        /// Calculate Area for a Shape
        /// </summary>
        /// <returns>Area as a float</returns>
        public override float Area()
        {
            return this.Top * this.Left;
        }
    }
}
