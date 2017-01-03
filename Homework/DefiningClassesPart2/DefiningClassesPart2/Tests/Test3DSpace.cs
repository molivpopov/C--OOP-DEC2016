namespace Tests
{
    using System;
    using PathInSpace;
    using PathInSpace.Common;

    class Test3DSpace
    {
        static void Main()
        {
            // generate path
            var p = new Point3D[] { new Point3D(2, 2, 2), new Point3D(4, 4, 4) };
            var pathSet = new Path(p);
            Console.WriteLine(string.Join("", p));

            // save the path on the disk
            PathStorage.PutData(".\\Path.txt", pathSet);

            // show the start point of the Coordinate sysytem
            Console.WriteLine("---------start point of system------");
            Console.WriteLine(StartCoordSysytem.O);

            // get path from file
            Console.WriteLine("get path from file and print");
            Console.WriteLine(string.Join("", PathStorage.GetData(".\\Path.txt").PointsInPath));
        }
    }
}
