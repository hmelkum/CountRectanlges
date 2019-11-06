using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectAligVisualization
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsNext(Point p)
        {
            return this.Y == p.Y ? true : false;
        }

        private List<Point> GetPointsAbove(Point[] points)
        {
            List<Point> above = new List<Point>();

            foreach (Point p in points)
            {
                if (this.X == p.X && this.Y < p.Y) above.Add(p);
            }

            return above;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        static public KeyValuePair<int, List<int[]>> MatchesByY(Point pa, Point pb, Point[] points)
        {
            List<Point> pl1 = pa.GetPointsAbove(points);
            List<Point> pl2 = pb.GetPointsAbove(points);
            int n = 0;
            List<int[]> rectList = new List<int[]>();

            foreach (Point p1 in pl1)
            {
                foreach (Point p2 in pl2)
                {
                    if (p1.Y == p2.Y)
                    {
                        n += 1;
                        rectList.Add(new int[] { pa.X, pa.Y, p2.X - pa.X, p1.Y - pa.Y });
                    }
                }
            }

            return new KeyValuePair<int, List<int[]>>(n, rectList);
        }
    }
}
