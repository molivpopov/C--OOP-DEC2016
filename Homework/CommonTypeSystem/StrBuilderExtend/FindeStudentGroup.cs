namespace ExtendMethod
{
    using Student;
    using System.Collections.Generic;
    public static class FindeStudentGroup
    {
        public static IEnumerable<T> FindGroup<T>(this IEnumerable<T> list, int group)
            where T : IGroup
        {
            var res = new List<T>();
            foreach (var item in list)
            {
                if (item.GroupNumber == group)
                {
                    res.Add(item);
                }
            }
            return res;
        }
        public static List<string> ToFullName<T>(this IEnumerable<T> list)
            where T : INames
        {
            var res = new List<string>();
            foreach (var item in list)
            {
                res.Add(item.FirstName + " " + item.LastName);
            }

            return res;
        }
        public static List<List<int>> ToMarks<T>(this IEnumerable<T> list, int mark)
            where T : INames
        {
            //var res = new List<int>();
            var res = new List<List<int>>();
            foreach (var item in list)
            {
                if (item.Marks.Contains(mark))
                {
                    res.Add(item.Marks);
                }
                
            }

            return res;
        }
    }
}
