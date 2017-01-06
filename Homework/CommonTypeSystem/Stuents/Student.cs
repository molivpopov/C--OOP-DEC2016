using System.Collections.Generic;

namespace Student

{
    public class Student : IGroup, INames
    {
        // в този клас прескачам конструктор, валидации...
        // те не са нужни за целта на домашното
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}, age:{2}", FirstName, LastName, Age);
        }

        public string ToPrint()
        {
          return string.Format((this.ToString()+"\nFN:{0}, Tel:{1}, Email:{2}, Group numebr{3}\nMarks:{4}"),FN, Tel, Email, GroupNumber, string.Join(", ", Marks));
        }
    }
}
