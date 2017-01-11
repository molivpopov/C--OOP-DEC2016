namespace AnimalHierarchy
{
    using Commons;
    using Enums;
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age)
        {
            base.Gender = Sex.female;
        }
        public override string ToString()
        {
            return string.Format(Constants.PatternToPrintAnimals, base.ToString(), this.GetType().Name.ToString(), base.SoundType);
        }
    }
}
