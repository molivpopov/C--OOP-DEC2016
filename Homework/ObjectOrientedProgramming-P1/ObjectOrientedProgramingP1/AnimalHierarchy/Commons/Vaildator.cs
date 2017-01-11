namespace AnimalHierarchy.Commons
{
    using System;
    using SchoolClasses.Commons;
    public static class Vaildator
    {
        public static object ParsEnum(Type type, string text)
        {
            object result = null;

            try
            {
                result = Enum.Parse(type, text);
            }
            catch (ArgumentException)
            {
                result = Enum.ToObject(type, 0); //0 aways meen - not set
            }

            return result;
        }
        public static void CheckAge(float age)
        {
            if (age < 0 || age > Constants.MaximalAgeAnimal)
            {
                throw new ArgumentOutOfRangeException(Constants.ImpossibalAge);
            }
        }
        public static void NullName(string name)
        {
            Validator.NullName(name);
        }
    }
}
