namespace PathInSpace
{
    using System.IO;
    // I use Newtonsoft.Json to serialize and deserialize data, to put or read them from disk
    // please to use Newtonsoft.Json, build solution (press F6 key)
    using Newtonsoft.Json;
    using Common;
    using Commons;

    [Version("D.Popov", version = 2.1)]
    public static class PathStorage
    {
        // this fileName contain the name and full path of file
        public static Path GetData(string fileName)
          {
            // get DataBase from faile
            Validator.NullFileName(fileName);
            string DB = File.ReadAllText(fileName);
            var deserializedPath = JsonConvert.DeserializeObject<Point3D[]>(DB);
            return new Path(deserializedPath);
        }
        public static void PutData(string fileName, Path path)
        {
            // save DataBase to faile
            Validator.NullFileName(fileName);
            string DataToPutOnDisk = JsonConvert.SerializeObject(path.PointsInPath);
            File.WriteAllText(fileName, DataToPutOnDisk);
        }

    }
}
