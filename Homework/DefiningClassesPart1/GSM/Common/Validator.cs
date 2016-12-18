namespace MobilePhone.Common
{
    using System;
    using System.Text.RegularExpressions;
    public static class Validator
    {
        public static void ValidateNullName(string name)
        {
            if (name == "" || name == null)
            {
                throw new ArgumentNullException(Constants.NullNames);
            }

        }
        public static void ValidateLenghtOfName(string name)
        {
            if (name.Length < Constants.MinLenghtOfName || name.Length > Constants.MaxLenghtOfName)
            {
                throw new ArgumentException(string.Format(Constants.NameLenght, Constants.MinLenghtOfName, Constants.MaxLenghtOfName));
            }
        }
        public static void ValidateNames(string name)
        {
            Regex manifacturerRegex = new Regex(Constants.PatternOfManifacturer);
            var matches = manifacturerRegex.Matches(name);

            if (matches.Count > 1 || matches[0].Length != name.Length)
            {
                throw new ArgumentOutOfRangeException(Constants.OnlyLettersMSG);
            }
        }
        public static void ValidatePhoneNumber(string name)
        {
            Regex manifacturerRegex = new Regex(Constants.PatternOfPhoneNumber);
            var matches = manifacturerRegex.Matches(name);

            if (matches.Count > 1 || matches[0].Length != name.Length)
            {
                throw new ArgumentOutOfRangeException(Constants.OnlyPhoneNumber);
            }
        }
        public static object ParsEnum(Type type, string text)
        {
            object result = null;

            try
            {
                result = Enum.Parse(type, text);
            }
            catch (ArgumentException)
            {
                result = Enum.ToObject(type, 0); //0 aways meen - unknown type
            }

            return result;
        }
    }
}
