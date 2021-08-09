namespace Polygon
{
    public class Point
    {
        int _xcoordinate;
        int _ycoordinate;
        public Point(int xcoordinate, int ycoordinate)
        {
            _xcoordinate = xcoordinate;
            _ycoordinate = ycoordinate;
        }
        public int Xcoordinate => _xcoordinate;
        public int Ycoordinate => _ycoordinate;
    }
}
