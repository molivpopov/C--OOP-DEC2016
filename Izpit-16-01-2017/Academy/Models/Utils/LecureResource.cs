namespace Academy.Models.Utils
{
    using Models.Contracts;

    public abstract class LecureResource : ILectureResouce
    {
        private const string PatternToPrint = "    * Resource:\n     - Name: {0}\n     - Url: {1}\n     - Type: {2}";

        public LecureResource(string name, string url)
        {
            Validator.CorrectName(name, 3, 15, Constants.ResourceCorrectName);
            this.Name = name;
            Validator.CorrectName(url, 5, 150, Constants.ResourceURL);
            this.Url = url;
        }

        public string Name
        {
            get; set;
        }

        public string Url
        {
            get; set;
        }

        public string Type { get; set; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, Name, Url, Type);
        }
    }
}
