namespace AnimalHierarchy
{
    using Commons;
    using Contracts;
    using Enums;
    public class Dog : Animal
    {
        public Dog(string name, int ageInYears) : base(name, ageInYears)
        {
            base.GenusType = FamilyType.mammal;
            base.SoundType = SoundType.barking;
        }
        public Dog(string name, int ageInYears, Sex sex) : this(name, ageInYears)
        {
            base.Gender = sex;
        }
        public override string ToString()
        {
            return string.Format(Constants.PatternToPrintAnimals, base.ToString(), this.GetType().Name.ToString(), base.SoundType);
        }
    }
}
