namespace PathInSpace
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Commons;
    using Common;

    [Version("D.Popov", version = 3.2)]
    public class Path
    {
        // this constructor take array of Point3D and set the proparty
        public Path(Point3D[] points)
        {
            Validator.NullPath(points);
            this.PointsInPath = points.ToList();
        }

        public ICollection<Point3D> PointsInPath { get; private set; }

        public void AddPoint(Point3D pnt)
        {
            this.PointsInPath.Add(pnt);
        }

        // if you try to remove an nonexisting point this method return false
        public bool RemovePoint(Point3D pnt)
        {
            if (this.PointsInPath.Count <= 2)
            {
                throw new ArgumentNullException(Constants.CannotRemoveFromNull);
            }

            return this.PointsInPath.Remove(pnt);
        }
        public string ToPrint()
        {
            string res = string.Format(Constants.PrintNumberOfPointInPath, this.PointsInPath.Count);
            this.PointsInPath.ToList().ForEach(x => res += x);

            return res;
        }
    }
}
