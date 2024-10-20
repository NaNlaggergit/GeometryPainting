using System.Collections.Generic;
using Avalonia.Media;
using Geometry;

namespace GeometryPainting
{
    static public class SegmentExtensions
    {
        public static Dictionary<Segment, Color> dict = new Dictionary<Segment, Color>();
        public static Color GetColor(this Segment segment)
        {
            if (dict.ContainsKey(segment))
            {
                return dict[segment];
            }
            else
            {
                return Colors.Black;
            }
        }
        public static void SetColor(this Segment segment,Color color)
        {
            dict[segment] = color;
        }
    }
}