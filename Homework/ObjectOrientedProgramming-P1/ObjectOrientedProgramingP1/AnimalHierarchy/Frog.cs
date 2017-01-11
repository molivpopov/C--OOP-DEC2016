namespace AnimalHierarchy
{
    using Commons;
    using Contracts;
    using Enums;
    public class Frog : Animal
    {
        public Frog(string name, float ageInYears) : base(name, ageInYears)
        {
            base.GenusType = FamilyType.amphibian;
            base.SoundType = SoundType.croak;
        }
        public Frog(string name, float ageInYears, Sex sex) : this(name, ageInYears)
        {
            base.Gender = sex;
        }
        public override string ToString()
        {
            return string.Format(Constants.PatternToPrintAnimals, base.ToString(), this.GetType().Name.ToString(), base.SoundType);
        }
    }
}
