namespace SchoolClasses
{
    using SchoolClasses.Commons;
    using Contracts;
    using System;
    using System.Collections.Generic;

    public class Disciplines : ICommantable
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.NullName(value);
                this.name = value;
            }
        }
        public int NumberOfLecture { get; set; }
        public int NumberOfExercises { get; set; }
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
    }
}
