namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    public class Class : ICommantable
    {
        public string Identifier { get; set; }
        public IList<Student> Students { get; set; }
        public IList<Teacher> Teachers { get; set; }
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
