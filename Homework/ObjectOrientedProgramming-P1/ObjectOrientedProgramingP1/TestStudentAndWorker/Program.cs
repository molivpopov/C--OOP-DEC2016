namespace TestStudentAndWorker
{
    using System;
    using System.Collections.Generic;
    using StudentsAndWorkers;
    using System.Linq;
    using SchoolClasses.Contracts;
    class Program
    {
        static void Main()
        {
            var students = new List<StudentFromWorker>()
            {
                new StudentFromWorker("Ivan", "Pentchev", 2),
                new StudentFromWorker("Anton", "Thehov", 2),
                new StudentFromWorker("Todor", "Kosmatkov", 2),
                new StudentFromWorker("Aliby", "Haltavia", 3),
                new StudentFromWorker("Trouman", "Capoty"),
                new StudentFromWorker("Troubadour", "Stoianov", 7),
                new StudentFromWorker("Zoro", "Ploskov", 2),
                new StudentFromWorker("Zoro", "Halata", 5),
                new StudentFromWorker("Pepi", "Tialoto", 5),
                new StudentFromWorker("Ivan", "Livanov", 1),
            };

            // setup worker
            var workers = new List<Worker>()
            {
                new Worker("Todor", "Koremov", 255),
                new Worker("Karamfil", "Bliznakov", 18),
                new Worker("Botox", "Totemov", 367),
                new Worker("Buldozer", "Krumov", 255),
                new Worker("Kaloian", "Budkata", 466),
                new Worker("Anton", "Poboinika", 123),
                new Worker("Lebed", "Tumorev", 555),
                new Worker("Baba", "Iaga", 345),
                new Worker("Baba", "Stoina", 23),
                new Worker("Lora", "Krumova", 100),
            };

            Console.WriteLine("All Student in list:\n{0}", string.Join("\n", students));

            var sortedByGrade = students.OrderBy(x => x.Grade);
            Console.WriteLine("\nAll Student sorted by grade:\n{0}", string.Join("\n", sortedByGrade));

            Console.WriteLine("\nAll Worker in list:\n{0}", string.Join("\n", workers));
            var sortedWorkerBySalary = workers.OrderBy(x => x.MoneyPerHour());

            Console.WriteLine("\nAll Worker sorted by salary:\n{0}", string.Join("\n", sortedWorkerBySalary));

            // merge using new Anonimus type
            var mergedListNewAnonimus = students
                .Select(x => new { FirstName = x.FirstName, LastName = x.LastName })
                .Concat(workers.Select(x => new { FirstName = x.FirstName, LastName = x.LastName }))
                .OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            Console.WriteLine("\nAll humen merged using New Anonimus type:\n{0}", string.Join("\n", mergedListNewAnonimus));

            // merge by converting to string
            var mergedListString = students
                .Select(x => x.ToString())
                .Concat(workers.Select(x => x.ToString()))
                .OrderBy(x => x);
            Console.WriteLine("\nAll humen merged by converting to string:\n{0}", string.Join("\n", mergedListString));

            // merge using down Casting
            var mergedListCasting = new List<Human>();
            mergedListCasting.AddRange(students);
            mergedListCasting.AddRange(workers);
            Console.WriteLine("\nAll humen merged by Casting, odered by firstname:\n{0}", string.Join("\n", mergedListCasting.OrderBy(x => x.FirstName)));
        }
    }
}
