namespace SchoolClasses.Commons
{
    public static class NumberGenerator
    {
        private static int number = 0;

        // pattern is string formater for generate unical class number
        public static string GetNumber(string pattern, int padLeft)
        {
            Validator.FullNumber(++number, padLeft);
            return string.Format(pattern, (number).ToString().PadLeft(padLeft, '0'));
        }
    }
}
