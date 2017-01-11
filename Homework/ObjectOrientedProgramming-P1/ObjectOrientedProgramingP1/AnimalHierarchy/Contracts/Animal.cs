namespace AnimalHierarchy.Contracts
{
    using Enums;
    using Commons;
    public abstract class Animal : ISound
    {
        private const string PatternToPrint = "My name is {0}, i am {1} years old.";
        public Animal(string name, float ageInYears)
        {
            Vaildator.CheckAge(ageInYears);
            Age = ageInYears;
            Vaildator.NullName(name);
            Name = name;
        }
        public string Name { get; private set; }
        public float Age { get; private set; }
        public FamilyType GenusType { get; set; }
        public SoundType SoundType { get; set; }
        public Sex Gender { get; set; }
        public override string ToString()
        {
            return string.Format(PatternToPrint, Name, Age);
        }
    }
}
