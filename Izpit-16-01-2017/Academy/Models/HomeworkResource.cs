namespace Academy.Models
{
    using Academy.Models.Utils;
    using System;
    public class HomeworkResource : LecureResource
    {
        private const string PatternToPrint = "\n{0}\n     - Due date: {1}";

        public HomeworkResource(string name, string url, DateTime duestartDate) : base(name, url)
        {
            base.Type = "Homework";
            DueDate = duestartDate.AddDays(7);
        }

        public DateTime DueDate { get; set; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, base.ToString(), DueDate);
        }
    }
}
