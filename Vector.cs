using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Vector
    {
        public double X=0.0;
        public double Y=0.0;
        public double GetLength()
        {
            return Geometry.GetLength(this);
        }
        public Vector Add(Vector vector2)
        {
            return Geometry.Add(this, vector2);
        }
        public bool Belongs(Segment segment)
        {
            return Geometry.IsVectorInSegment(this,segment);
        }
    }
}
