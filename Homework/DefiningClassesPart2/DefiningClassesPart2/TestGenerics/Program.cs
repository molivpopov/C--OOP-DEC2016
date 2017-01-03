namespace TestGenerics
{
    using System;
    using MyGeneric;
    using Matrix;
    using Commons.Calculator;
    using Commons;
    using PathInSpace;
    public class TestGenerics
    {
        static void Main()
        {
            // test method Add
            var p = new MyList<decimal>();
            p.Add(12);
            p.Add(3);
            p.Add(8);
            Console.WriteLine("elements of type {0} are:{1}", p.GetType().Name, p);

 

            //test find max
            var maxNumber = p.Max();
            Console.WriteLine(p.Max());
            var chr = new MyList<char>();
            chr.Add('c');
            chr.Add('b');
            chr.Add('a');
            Console.WriteLine("\nelements of type {0} are:{1}\n", p.GetType().Name, chr);
            Console.WriteLine("the maximal item in previus sequance are:{0}", chr.Max());

            var str = new MyList<string>();
            str.Add("hello");
            str.Add("my");
            str.Add("friend");
            str.Add("All");
            str.Add("all");
            str.RemoveAt(1);
            Console.WriteLine("\nelements of type {0} are:{1}\n", p.GetType().Name, str);
            Console.WriteLine("Lexicographic smallest (first) string is:{0}", str.Min());

            // init matrixs to test operators
            var mat1 = new int[3, 2] { { 1, 2 }, { 3, 7 }, { 8, 9 } };
            var mat2 = new int[3, 2] { { 2, 1 }, { 7, 3 }, { 9, 9 } };
            var matEmpty = new int[3, 2] { { 0, 0 }, { 0, 0 }, { 0, 0 } };
            var myMat1 = new Matrix<int, IntCalculator>(mat1);
            var myMat2 = new Matrix<int, IntCalculator>(mat2);

            Console.WriteLine("\nprint myMat2\n{0}", myMat2);
            var myEmptyMat = new Matrix<int, IntCalculator>(matEmpty);
            Console.WriteLine("print myEmptyMat\n{0}\n", myEmptyMat);

            // test operators
            var num = myMat1[1, 1];
            var sumMattrix = myMat1 + myMat2;
            var subMattrix = sumMattrix - myMat1;
            var prodMattrix = myMat1 * myMat2;

            // finding the next bigest 
            int n = 42;
            var bigestPowOfTwo = 1 << (int)(Math.Log(n) / Math.Log(2)) + 1;

            //printing version 3 classes
            PrintVersionInfo(typeof(Path));
            PrintVersionInfo(typeof(PathStorage));
            PrintVersionInfo(typeof(Matrix<int, IntCalculator>));

        }
        public static void PrintVersionInfo(Type T)
        {
            Console.WriteLine("Author information for {0}", T.Name);
            //var ver = T.Assembly;
           // Console.WriteLine("Assembly:{0}", ver);
            Attribute[] attrs = VersionAttribute.GetCustomAttributes(T);  // reflection

            foreach (Attribute attr in attrs)
            {
                if (attr is VersionAttribute)
                {
                    VersionAttribute a = (VersionAttribute) attr;
                    Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
                }
            }
        }
    }
}
