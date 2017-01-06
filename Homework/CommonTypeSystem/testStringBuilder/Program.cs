namespace testStringBuilder
{
    using System;
    using System.Text;
    using ExtendMethod;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            //01 test subString from StringBuilder
            var p = new StringBuilder("hello!");
            Console.WriteLine("word hello, SubString ovarload with start pos from 1: {0}", p.Substring(1));
            Console.WriteLine("word hello, SubString ovarload with start pos from 1 and length 3: {0} ", p.Substring(1, 3));

            //02 test IEnumerable<T>
            var list = new List<int>() { 8, 5, 3, 2, 1 };
            Console.WriteLine("\nIn the sequence of numbers : {0}", string.Join(", ", list));
            Console.WriteLine("min:{0}, max:{1}, sum:{2}, product:{4}, average:{3:f2}", list.Min(), list.Max(), list.Sum(), list.Average(), list.Prod());
        }
    }
}
