namespace SchoolClasses.Commons
{
    using System;
    public static class Validator
    {

        public static void NullName(string name)
        {
            if (name == "" || name == null)
            {
                throw new ArgumentNullException(Constants.NullNames);
            }

        }
        public static void RealSalary(decimal salary)
        {
            // check salary
        }
        public static void RealName(string name)
        {
            // check validity of name
        }
        public static void FullNumber(int number, int padleft)
        {
            if (number >= (Math.Pow(10, padleft)) || number < 0 )
            {
                throw new ArgumentOutOfRangeException(Constants.FullID);
            }
        }

    }
}

