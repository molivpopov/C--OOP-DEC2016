namespace StringFormatTest
{
    using System;
    class Program
    {
        static void Main()
        {
            string line = "------------";
            string test =
                "atom     {0}\n"+
                "books    {1}\n"+
                "teleport {2}";

            Console.WriteLine(line);

   
            Console.WriteLine("a\t{0,3}\naa\t{1,3}\naaa\t{2,3}", 1, 12, 123);
            Console.WriteLine("a\t{0,3}\naa\t{1,3}\naaa\t{2,4}", "1", "12", "Command");
            Console.WriteLine(test, 1,12,123);





        }
    }
}
