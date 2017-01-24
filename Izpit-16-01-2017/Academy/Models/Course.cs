namespace Academy.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Utils;

    public class Course : ICourse
    {
        private const string PatternToPrint = "* Course:\n - Name: {0}\n - Lectures per week: {1}\n - Starting date: {2}\n - Ending date: {3}\n - Onsite students: {5}\n - Online students: {6}\n - Lectures:\n{4}";
        private const string NoLecture = "  * There are no lectures in this course!";

        private string name;
        private int lecturesPerWeek;

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            Validator.CorrectName(name, 3, 45, Constants.CourseCorrectName);
            this.Name = name;
            this.lecturesPerWeek = Validator.CorrectLecturePerWeek(lecturesPerWeek);
            this.StartingDate = DateTime.Parse(startingDate);
            this.Lectures = new List<ILecture>();
            this.OnlineStudents = new List<IStudent>();
            this.OnsiteStudents = new List<IStudent>();
        }

        public DateTime EndingDate
        {
            get
            {
                return this.StartingDate.AddDays(30);
            }

            set
            {
                // what is mean?
                //throw new NotImplementedException();
            }
        }

        public IList<ILecture> Lectures
        { get; set; }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }

            set
            {
                this.lecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public IList<IStudent> OnlineStudents
        { get; set; }

        public IList<IStudent> OnsiteStudents
        { get; set; }

        public DateTime StartingDate { get; set; }

        public override string ToString()
        {
            var lecture = this.Lectures.Count == 0
                ? NoLecture
                : string.Join("\n", Lectures);

            return string.Format(PatternToPrint, Name, LecturesPerWeek, StartingDate, EndingDate, lecture, OnsiteStudents.Count, OnlineStudents.Count);
        }
    }
}
