using System.Collections.Generic;

namespace Polygon
{
    /*-1,1     | 0,1    1,1
              |
  -1,0 -------|------- 1,0
              |0,0
              |
     -1,-1    |0,-1    1,-1

    */
    /// <summary>
    /// Builds polygons
    /// </summary>
    public class PolygonBuilder
    {
        public PolygonBuilder()
        {

        }

        /*         | 0,1    
                   |
       -1,0 -------|------- 1,0
                   |0,0
                   |
                   |    
    */
        public static Polygon BuildTriangle()
        {
            IList<Point> points = new List<Point>();
            points.Add(new Point(1, 0));
            points.Add(new Point(0, 1));
            points.Add(new Point(-1, 0));
            Polygon polygon = new Polygon(points);
            return polygon;
        }

        /*-1,1 |       1,1
              |
       -------|-------
              |0,0
              |
     -1,-1    |       1,-1

    */
        public static Polygon BuildSquare()
        {
            IList<Point> points = new List<Point>();
            points.Add(new Point(1, 1));
            points.Add(new Point(-1, 1));
            points.Add(new Point(-1, -1));
            points.Add(new Point(1, -1));
            Polygon polygon = new Polygon(points);
            return polygon;
        }


        /*-1,1 |       1,1
            |
     -------|-------
            |0,0
            |
   -1,-1    |       1,-1
            |
            |
             0,-2

  */

        public static Polygon BuildPentagon()
        {
            IList<Point> points = new List<Point>();
            points.Add(new Point(1, 1));
            points.Add(new Point(-1, 1));
            points.Add(new Point(-1, -1));
            points.Add(new Point(0, -2));
            points.Add(new Point(1, -1));
            Polygon polygon = new Polygon(points);
            return polygon;
        }
    }
}
