using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public static class Geometry
    {
        public static double GetLength(Vector vector)
        {
            var lenght=Math.Sqrt(vector.X*vector.X + vector.Y*vector.Y);
            return lenght;
        }
        public static double GetLength(Segment segment)
        {
            var x = segment.Begin.X - segment.End.X;
            var y = segment.Begin.Y - segment.End.Y;
            var length = Math.Sqrt(x * x + y * y);
            return length;
        }
        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            var length = GetLength(segment);
            var vecEnd = new Segment(vector, segment.End);
            var lengthEnd = GetLength(vecEnd);
            var vecBegin = new Segment(vector, segment.Begin);
            var lengthBegin = GetLength(vecBegin);
            var sum = lengthBegin + lengthEnd;
            return sum == length;
        }
        public static Vector Add(Vector vector1,Vector vector2)
        {
            var vector3 = new Vector();
            vector3.X = vector1.X + vector2.X;
            vector3.Y = vector1.Y + vector2.Y;
            return vector3;
        }
    }
}
