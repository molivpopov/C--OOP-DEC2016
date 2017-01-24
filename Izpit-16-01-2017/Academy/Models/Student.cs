namespace Academy.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Utils;
    using System.Linq;
    using Enums;
    using Utils.Contracts;

    public class Student : IStudent
    {
        private const string PatternToPrint = "* Student:\n - Username: {0}\n - Track: {1}\n - Course results:\n  {2}";
        private const string NoCourseResult = "* User has no course results!";

        public Student(string username, string track)
        {
            this.Track = (Track) Validator.ParsEnum(typeof(Track), track);
            Validator.CorrectName(username, 3, 16, Constants.TrainerCorrectName);
            this.Username = username;
            this.CourseResults = new List<ICourseResult>();
        }

        public IList<ICourseResult> CourseResults
        { get; set; }

        public Track Track
        { get; set; }

        public string Username
        { get; set; }

        public override string ToString()
        {
            var corseResult = CourseResults.Count == 0
                ? NoCourseResult
                : string.Join("\n", CourseResults);

            return string.Format(PatternToPrint, this.Username, this.Track, corseResult);
        }
    }
}
