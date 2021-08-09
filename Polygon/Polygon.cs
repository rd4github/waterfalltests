using System;
using System.Collections.Generic;
using System.Linq;


namespace Polygon
{
    public class Polygon
    {
        IList<Point> _points;
        public Polygon()
        {
            _points = new List<Point>();
        }
        public Polygon(IList<Point> points)
        {
            _points = new List<Point>();
            _points = points;
        }

        private void ConstructPolygon(int points)
        {
            if (points < 2) throw new ArgumentException("Can not construct a polygon with {points} points. Atealst 3 points are needed");

        }

        public IList<Point> Points => _points;

        public Point Center()
        {
            int totalPoints = _points.Count;
            if (totalPoints < 3) return new Point(int.MinValue, int.MinValue);

            int centerX = _points.Sum(point => point.Xcoordinate) / totalPoints;
            int centerY = _points.Sum(point => point.Ycoordinate) / totalPoints;
            return new Point(centerX, centerY);
        }

        public double Angle(Point center, Point vertex)
        {
            double latiitude = (center.Xcoordinate - vertex.Xcoordinate);
            double longitude = Math.Abs(center.Ycoordinate - vertex.Ycoordinate);

            return Math.Atan2(longitude, latiitude).ToDegrees();
        }

    }
}
