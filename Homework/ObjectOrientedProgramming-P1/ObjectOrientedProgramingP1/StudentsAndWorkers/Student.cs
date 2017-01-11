namespace StudentsAndWorkers
{
    using SchoolClasses;
    public class StudentFromWorker : Student
    {
        private const int DefaultGrade = 1;
        public StudentFromWorker(string firstName, string lastName) : base(firstName, lastName)
        {
            Grade = DefaultGrade;
        }
        public StudentFromWorker(string firstName, string lastName, int grade) : this(firstName, lastName)
        {
            Grade = grade;
        }
        public int Grade { get; private set; }

        public override string ToString()
        {
            return base.ToString() + ", grade:" + this.Grade;
        }
    }
}
