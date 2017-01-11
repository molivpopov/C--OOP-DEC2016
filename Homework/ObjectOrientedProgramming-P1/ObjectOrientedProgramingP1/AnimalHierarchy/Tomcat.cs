namespace AnimalHierarchy
{
    using Commons;
    using Enums;
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age)
        {
            base.Gender = Sex.male;
        }

        public override string ToString()
        {
            return string.Format(Constants.PatternToPrintAnimals, base.ToString(), this.GetType().Name.ToString(), base.SoundType);
        }
    }
}
