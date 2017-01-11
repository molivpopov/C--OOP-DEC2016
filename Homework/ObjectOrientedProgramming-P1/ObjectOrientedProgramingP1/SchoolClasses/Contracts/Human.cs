namespace SchoolClasses.Contracts
{
    using Commons;

    public abstract class Human : IName
    {
        private const string PatternToPrint = "{0} {1}";
        private string firstName;
        private string lastName;
        public Human(string firstName, string lastName)
        {
            Validator.NullName(firstName);
            this.FirstName = firstName;
            Validator.NullName(lastName);
            this.LastName = lastName;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                Validator.RealName(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Validator.RealName(value);
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format(PatternToPrint, FirstName, LastName);
        }
    }
}
