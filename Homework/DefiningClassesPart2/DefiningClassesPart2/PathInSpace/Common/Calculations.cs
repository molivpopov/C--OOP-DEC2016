namespace PathInSpace.Common
{
    using System;

    public static class Calculations
    {
        public static double DistanceTwoPoint(Point3D a, Point3D b)
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            double dz = a.Z - b.Z;

            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
        public static Point3D ConvertFromGPSPoint(PointGPS point)
        {
            // тук трябва да се имплементире код-а за преобразуване
            // от GPS към нашата Евклидова координатна система
            // това обаче не е предмет на това домашно
            throw new NotImplementedException();
        }
        public static PointGPS ConvertFrom3DPoint(Point3D point)
        {
            // тук трябва да се имплементире код-а за преобразуване
            // от нашата Евклидова координатна система към GPS точка
            // това обаче не е предмет на това домашно
            throw new NotImplementedException();
        }
    }
}
