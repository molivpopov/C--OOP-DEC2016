namespace PathInSpace.Common
{
    public struct Point3D
    {
        private const string PatternToPrint = "X={0:f2}, Y={1:f2}, Z={2:f2}\n";

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public override string ToString()
        {        
            return string.Format(PatternToPrint, X, Y, Z);
        }
    }
}
