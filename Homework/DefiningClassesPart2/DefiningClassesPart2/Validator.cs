namespace Common
{
    using System;
    public static class Validator
    {
        public static void NullPath(Point3D[] path)
        {
            if (path == null || path.Length < 2)
            {
                throw new ArgumentNullException(Constants.NullPath);
            }
        }
    }
}
