namespace PathInSpace
{
    public struct Point3D
    {
        private const string PatternToPrint = "X={0:f2}, Y={1:f2}, Z={2:f2}\n";
        public double X;
        public double Y;
        public double Z;
        public override string ToString()
        {        
            return string.Format(PatternToPrint, X, Y, Z); ;
        }
    }
}
