using System;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon polygon = PolygonBuilder.BuildTriangle();

            #region Traingle polygon
            Point center = polygon.Center();
            Console.WriteLine($"Center of Polygon: {center.Xcoordinate},{center.Ycoordinate}");


            double angle = polygon.Angle(center, polygon.Points[0]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[0].Xcoordinate},{polygon.Points[0].Ycoordinate} >> [{angle}]");


            angle = polygon.Angle(center, polygon.Points[1]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[1].Xcoordinate},{polygon.Points[1].Ycoordinate} >> [{angle}]");

            angle = polygon.Angle(center, polygon.Points[2]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[2].Xcoordinate},{polygon.Points[2].Ycoordinate} >> [{angle}]");
            #endregion

            polygon = PolygonBuilder.BuildSquare();

            #region Square polygon
            center = polygon.Center();
            Console.WriteLine($"Center of Polygon: {center.Xcoordinate},{center.Ycoordinate}");

            angle = polygon.Angle(center, polygon.Points[0]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[0].Xcoordinate},{polygon.Points[0].Ycoordinate} >> [{angle}]");

            angle = polygon.Angle(center, polygon.Points[1]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[1].Xcoordinate},{polygon.Points[1].Ycoordinate} >> [{angle}]");

            angle = polygon.Angle(center, polygon.Points[2]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[2].Xcoordinate},{polygon.Points[2].Ycoordinate} >> [{angle}]");
            #endregion

            polygon = PolygonBuilder.BuildPentagon();

            #region Pentagon
            center = polygon.Center();
            Console.WriteLine($"Center of Polygon: {center.Xcoordinate},{center.Ycoordinate}");

            angle = polygon.Angle(center, polygon.Points[0]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[0].Xcoordinate},{polygon.Points[0].Ycoordinate} >> [{angle}]");

            angle = polygon.Angle(center, polygon.Points[1]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[1].Xcoordinate},{polygon.Points[1].Ycoordinate} >> [{angle}]");

            angle = polygon.Angle(center, polygon.Points[2]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[2].Xcoordinate},{polygon.Points[2].Ycoordinate} >> [{angle}]");

            angle = polygon.Angle(center, polygon.Points[3]);
            Console.WriteLine($"Angle between point :{center.Xcoordinate},{center.Ycoordinate}   and {polygon.Points[3].Xcoordinate},{polygon.Points[3].Ycoordinate} >> [{angle}]");

            #endregion

            Console.Read();
        }
    }
}
