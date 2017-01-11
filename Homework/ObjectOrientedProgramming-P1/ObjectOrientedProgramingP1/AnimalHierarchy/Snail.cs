namespace AnimalHierarchy
{
    using Commons;
    using Contracts;
    using Enums;
    public class Snail : Animal
    {
        public Snail(string name, float ageInYears) : base(name, ageInYears)
        {
            base.GenusType = FamilyType.Mollusca;
            base.SoundType = SoundType.rustling;
        }
        public Snail(string name, float ageInYears, Sex sex) : this(name, ageInYears)
        {
            base.Gender = sex;
        }
        public override string ToString()
        {
            return string.Format(Constants.PatternToPrintAnimals, base.ToString(), this.GetType().Name.ToString(), base.SoundType);
        }
    }
}
