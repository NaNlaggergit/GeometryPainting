using Avalonia.Media;
using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Segment
    {
        public Vector Begin;
        public Vector End;
        public Segment(Vector begin, Vector end)
        {
            Begin = begin;
            End = end;
        }
        public Segment()
        {
            Begin = new Vector();
            End = new Vector();
        }
        public double GetLength()
        {
            return Geometry.GetLength(this);
        }
        public bool Contains(Vector vector)
        {
            return Geometry.IsVectorInSegment(vector, this);
        }
    }
}
