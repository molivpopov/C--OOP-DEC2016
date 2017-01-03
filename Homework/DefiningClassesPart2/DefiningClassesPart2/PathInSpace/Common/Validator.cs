namespace PathInSpace.Common
{
    using System;
    using Commons;
    public static class Validator
    {
        public static void NullPath(Point3D[] path)
        {
            if (path == null || path.Length < 2)
            {
                throw new ArgumentNullException(Constants.NullPath);
            }
        }
        public static void NullFileName(string fileName)
        {
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException(Constants.NullFileName);
            }
        }
    }
}
