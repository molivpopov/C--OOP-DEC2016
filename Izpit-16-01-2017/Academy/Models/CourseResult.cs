namespace Academy.Models
{
 
    using Contracts;
    using Academy.Models.Utils.Contracts;
    using Enums;
    //using Academy.Models.Enums;

    public class CourseResult : ICourseResult
    {
        private const string PatternToPrint = "* {0}: Points - {1}, Grade - {2}";
        private float examPoint;
        private float coursePoint;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;
            this.CoursePoints = float.Parse(coursePoints);
            this.ExamPoints = float.Parse(examPoints);
        }

        public ICourse Course
        { get; set; }


        public Grade Grade
        {
            get; set;
        }

        public float ExamPoints
        {
            get
            {
                return this.examPoint;
            }
            set
            {
                SetGrade(value);
                this.examPoint = value;
            }
        }

        public float CoursePoints
        {
            get
            {
                return this.coursePoint;
            }
            set
            {
                SetGrade(value);
                this.coursePoint = value;
            }
        }

        private void SetGrade(float point)
        {
            this.Grade = Grade.Failed;
            if (point >= 30 || CoursePoints >= 45) { this.Grade = Grade.Passed; };
            if (point >= 65 || CoursePoints >= 75) { this.Grade = Grade.Excellent; };
        }

        public override string ToString()
        {
            return string.Format(PatternToPrint, Course.Name, CoursePoints, Grade);
        }
    }
}
