
namespace Academy.Models.Utils
{
    using System;

    public static class Validator
    {
        public static void CorrectName(string name, int l, int r, string message)
        {
            if (string.IsNullOrEmpty(name) || name.Length < l || name.Length > r)
            {
                throw new ArgumentException(message);
            }

        }

        public static int CorrectLecturePerWeek(string lecturePerWeek)
        {
            int res;
            try
            {
                res = int.Parse(lecturePerWeek);
            }
            catch (Exception e)
            {
                throw new ArgumentException(Constants.CoursecorrectLecturePerWeek);
            };

            if (res < 1 || res > 7)
            {
                throw new ArgumentException(Constants.CoursecorrectLecturePerWeek);
            }

            return res;
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
                throw new ArgumentException(Constants.NotValidTrack); //0 aways meen - unknown type
            }

            return result;
        }
    }
}
