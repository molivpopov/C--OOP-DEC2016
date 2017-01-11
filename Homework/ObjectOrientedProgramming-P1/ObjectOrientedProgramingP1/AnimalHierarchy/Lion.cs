namespace AnimalHierarchy
{
    using Enums;
    using Commons;
    public class Lion : Cat
    {
        public Lion(string name, int age) : base(name, age)
        {
            base.SoundType = SoundType.roar;
        }

        public override string ToString()
        {
            return string.Format(Constants.PatternToPrintAnimals, base.ToString(), this.GetType().Name.ToString(), base.SoundType);
        }
    }
}
