namespace TestStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Student;
    using ExtendMethod;
    class Program
    {
        static void Main()
        {

            var students = new List<Student>
            {
               new Student() { FirstName = "Anton", LastName = "Petrov", Age=24, FN=12345, Tel="088774422", Email="Anton@abv.bg", GroupNumber=1, Marks=new List<int>{3,5,5,4 } },
               new Student() { FirstName = "Gosho", LastName = "Tonev", Age=22, FN=12345, Tel="027723422", Email="Gosho2@abv.bg", GroupNumber=2, Marks=new List<int>{3,3,4,3 }},
               new Student() { FirstName = "Pesho", LastName = "Gelev", Age = 19, FN=12345, Tel="088774422", Email="gelev@mail.bg", GroupNumber=2, Marks=new List<int>{6,6,6,6 }},
               new Student() { FirstName = "Teodor", LastName = "Buzev", Age = 27, FN=12345, Tel="02774422", Email="TBuzev@dir.bg", GroupNumber=1, Marks=new List<int>{2,4,5,4 }},
               new Student() { FirstName = "Zoro", LastName = "Bozata", Age = 18, FN=12345, Tel="0881274422", Email="Bozata@mail.bg", GroupNumber=2, Marks=new List<int>{6,4,4,5 }},
               new Student() { FirstName = "Zoro", LastName = "Atletha", Age = 31, FN=12345, Tel="088774422", Email="Atletha@yahoo.bg", GroupNumber=1, Marks=new List<int>{3,5,6,6 }},
            };

            Console.WriteLine("This Is the full list of student:\n{0}", string.Join("\n", students));

            // 03 First before last
            var FNameBeforLastName = students.FindAll(x => x.FirstName.CompareTo(x.LastName) < 0);
            var FNameBeforLastNameLINQ =
                from x in students
                where x.FirstName.CompareTo(x.LastName) < 0
                select x;
            Console.WriteLine("\nThis list of student is when the first name is befor the last:\n{0}", string.Join("\n", FNameBeforLastName));
            Console.WriteLine("\nSame list but made with LINQ:\n{0}", string.Join("\n", FNameBeforLastNameLINQ));


            // 04 Age range
            var ageRange = students.FindAll(x => x.Age >= 18 && x.Age <= 24);
            Console.WriteLine("\nThis list of student is when the age is betwen inclusiv 18 and 24:\n{0}", string.Join("\n", ageRange));

            // 05 Order students
            var orderedStudents = students.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            Console.WriteLine("\nThis Ordered list of student first by firstName then by last name:\n{0}", string.Join("\n", orderedStudents));

            // 06  Divisible by 7 and 3
            // now I finde the lentgh of first and last name and then check Divisible by 21 (7*3)
            var divisibleBy7And3 =
                from x in students
                where (x.FirstName.Length + x.LastName.Length + x.Age) % 21 == 0
                select x;
            //students.ForEach(x => Console.WriteLine(x.FirstName.Length + x.LastName.Length + x.Age));
            Console.WriteLine("\nThis students has a magic names:\n{0}", string.Join("\n", divisibleBy7And3));

            // 09 Student groups
            var studentGroup =
                from x in students
                where x.GroupNumber == 2
                select x;
            Console.WriteLine("\nList of student in group {0}:\n{1}", 2, string.Join("\n", studentGroup));

            // 10 Student groups - with extend method
            Console.WriteLine("\nSame made with extend method(group 1):\n{0}", string.Join("\n", students.FindGroup(1)));

            // 11 Extract students by email
            var studentInAbv = students.FindAll(x => x.Email.EndsWith("abv.bg"));
            Console.WriteLine("\nlist of student with e-mail in ABV:\n{0}", string.Join("\n", studentInAbv));

            // 12 Extract students by phone in Sofia
            var studentByPhone = students.FindAll(x => x.Tel.StartsWith("02"));
            Console.WriteLine("\nlist of student with phone in Sofia:\n{0}", string.Join("\n", studentByPhone));

            // 13 Extract students by marks
            var marksSix = new { FullName = students.FindAll(x => x.Marks.Contains(6)).ToFullName(), Marks = students.ToMarks(6) };
            for (int i = 0; i < marksSix.FullName.Count; i++)
            {
                Console.WriteLine("\nstudent:{0} has the mark six:\n{1}", marksSix.FullName[i], string.Join(", ", marksSix.Marks[i]));
            }

            // 14. Extract students with two marks
            var marksTwo = new { FullName = students.FindAll(x => x.Marks.Contains(2)).ToFullName(), Marks = students.ToMarks(2) };
            for (int i = 0; i < marksTwo.FullName.Count; i++)
            {
                Console.WriteLine("\nstudent:{0} has the mark two:\n{1}", marksTwo.FullName[i], string.Join(", ", marksTwo.Marks[i]));
            }


            // 17 Longest string
            int l = int.MinValue;
            var studentLongestName = new Student();
            students.ForEach(x => { if (x.FirstName.Length > l) { l = x.FirstName.Length; studentLongestName = x; } });
            Console.WriteLine("\nthe student with the longest first name is:{0}", studentLongestName);


            var longestNameWithExtendMethod = students.FindLOngestName();
            Console.WriteLine("\nthe student with the longest first name finded with extend method is:{0}", longestNameWithExtendMethod);

        }
    }
}
