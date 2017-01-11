namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Commons;

    public class Student : Human, ICommantable
    {
        private const int DifferentDigitInClassNumber = 4;
        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            ClassNumber = NumberGenerator.GetNumber(Constants.ComposingClassNumber, DifferentDigitInClassNumber);
        }
        public string ClassNumber { get; private set; }
        public List<int> Marks { get; set; }
        public IList<string> Comments
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public override string ToString()
        {
            var type = " (" + this.GetType().Name.ToString() + ")";
            return base.ToString() + type + string.Format(", class No:{0}", ClassNumber);
        }
    }
}
