namespace ExtendMethod
{
    using System.Collections.Generic;
    using System.Linq;
    public static class EnumerableExtends
    {
        public static T Sum<T>(this IEnumerable<T> list)
        {
            dynamic sum = (dynamic)0;
            foreach (var item in list)
            {
                sum += (dynamic) item;
            }

            return (dynamic)sum;
        }
        public static double Average<T>(this IEnumerable<T> list)
        {
            return (double)(dynamic) list.Sum() / list.Count();
        }
        public static T Prod<T>(this IEnumerable<T> list)
        {
            dynamic prod = (dynamic) 1;
            foreach (var item in list)
            {
                prod *= (dynamic) item;
            }

            return (dynamic) prod;
        }
        public static T Min<T>(this IEnumerable<T> list)
        {
            // get the first pos in list
            dynamic min = list.First();

            foreach (var item in list)
            {
               if (min > item)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> list)
        {
            // get the first pos in list
            dynamic max = list.First();

            foreach (var item in list)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }
      
    }
}
