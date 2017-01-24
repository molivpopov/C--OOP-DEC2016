namespace Academy.Models
{
    using Contracts;
    using Academy.Models.Utils.Contracts;
    using Enums;
    using System;
    using System.Collections.Generic;
    using Utils;


    public class Lecture : ILecture
    {
        private const string PatternToPrint = "  * Lecture:\n   - Name: {0}\n   - Date: {1}\n   - Trainer username: {2}\n   - Resources:{3}";
        private const string NoResource = "\n    * There are no resources in this lecture.";

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Trainer = trainer;
            Validator.CorrectName(name, 5, 30, Constants.LectureCorrectName);
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.Resouces = new List<ILectureResouce>();
        }


        public DateTime Date
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public IList<ILectureResouce> Resouces
        {
            get; set;
        }

        public ITrainer Trainer
        {
            get; set;
        }

        public override string ToString()
        {
            var resource = Resouces.Count == 0
                ? NoResource
                : string.Join("\n", Resouces);

            return string.Format(PatternToPrint, Name, Date, Trainer.Username, resource);
        }
    }
}
