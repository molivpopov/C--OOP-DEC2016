namespace MobilePhone.Common
{
    public static class Constants
    {
        public const string NullNames = "Models or manifacturer can not be null";
        public const string NameLenght = "Names must have more than {0} symbols and less than {1}";
        public const string PatternOfManifacturer = @"[a-zA-Z0-9]+";
        public const string PatternOfPhoneNumber = @"[a-zA-Z0-9+ ]+"; // you may type a phone whith latin letters
        public const string OnlyPhoneNumber = "Phone number must contain only Decimal digit, latin lettars, + and/or white space";
        public const string OnlyLettersMSG = "Name must contain only letters and/or decimal digits";
        public const string HaveNothingToDelete = "Nothing to Delete";
        public const string PatternToPrintMandatory =
            "Model:         {0}\n" +
            "Manifacturer:  {1}";

        public const int MinLenghtOfName = 3;
        public const int MaxLenghtOfName = 20;
        public const float CmPerInches = 2.54f;
        public const decimal PriceOfMinuteCall = 0.37m;
        public const long OneSecond = 10000000;

    }
}
