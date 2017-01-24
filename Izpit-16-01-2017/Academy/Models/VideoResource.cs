namespace Academy.Models
{
    using Academy.Models.Utils;
    using System;
    public class VideoResource : LecureResource
    {
        private const string PatternToPrint = "\n{0}\n     - Uploaded on: {1}";
        public VideoResource(string name, string url, DateTime uplodedOn) : base(name, url)
        {
            base.Type = "Video";
            UploadedOn = uplodedOn;
        }

        public DateTime UploadedOn { get; private set; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, base.ToString(), UploadedOn);
        }
    }
}
