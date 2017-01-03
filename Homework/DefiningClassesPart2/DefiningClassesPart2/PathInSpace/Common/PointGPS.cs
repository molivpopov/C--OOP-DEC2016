namespace PathInSpace.Common
{
    public struct PointGPS
    {
        private const string PatternToPrint = "latitude={0:f4}\", longitude={1:f4}\", altitude={2:f1}m\n";

        public PointGPS(double latitude, double longitude, double altitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Altitude = altitude;
        }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }


        public override string ToString()
        {
            return string.Format(PatternToPrint, Latitude, Longitude, Altitude);
        }
    }
}
