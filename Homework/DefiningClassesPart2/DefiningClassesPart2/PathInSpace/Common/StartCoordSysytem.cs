namespace PathInSpace.Common
{
    public static class StartCoordSysytem
    {
        // this is start of 3D the coordinate system
        private const double longitude = 23.3428386;
        private const double latitude = 42.6701096;
        private const double altitude = 590;

        // не видях някаква друга причина за това пропърти, освен
        // като връзка с някаква по-глобална координатна система
        // например GPS
        // тоест със следващия ред поставям нулата на координатната система
        // от точка 1 на условието
        // някъде в София - може би сградата на Телерик? :)
        public readonly static PointGPS O = new PointGPS(latitude, longitude, altitude);
    }
}
