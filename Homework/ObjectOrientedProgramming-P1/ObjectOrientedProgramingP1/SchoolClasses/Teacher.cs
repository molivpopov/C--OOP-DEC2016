namespace SchoolClasses
{
    using Contracts;
    using System.Collections.Generic;
    using System;

    public class Teacher : Human, ICommantable
    {
        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            SetOfDisciplines = new List<Disciplines>();
            Comments = new List<string>();
        }
        public IList<Disciplines> SetOfDisciplines { get; set; }
        public IList<string> Comments { get; set; }
    }
}
