namespace AnimalHierarchy
{
    using Contracts;
    using Enums;
    public class Cat : Animal
    {
        public Cat(string name, int ageInYears) : base(name, ageInYears)
        {
            base.GenusType = FamilyType.mammal;
            base.SoundType = SoundType.meow;
        }
        public Cat(string name, int ageInYears, Sex sex, SoundType sound) : this(name, ageInYears)
        {
            base.SoundType = sound;
            base.Gender = sex;
        }
    }
}
