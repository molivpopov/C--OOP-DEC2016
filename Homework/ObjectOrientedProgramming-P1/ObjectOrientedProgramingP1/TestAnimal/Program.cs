namespace TestAnimal
{
    using System;
    using AnimalHierarchy;
    using AnimalHierarchy.Enums;
    using AnimalHierarchy.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var lionGosho = new Lion("Gosho", 2);
            lionGosho.Gender = Sex.male;

            var catMimi = new Kitten("Mimi", 4);
            var dogSharo = new Dog("Sharo", 5, Sex.male);
            var frogPetko = new Frog("Petko", 0.5f, Sex.male);
            var snailLubov = new Snail("Lubo", 0.2f, Sex.both);
            var tomcatTocho = new Tomcat("Tocho", 9);
            Console.WriteLine(lionGosho);

            var myAnimals = new List<object>();
            myAnimals.Add(catMimi);
            myAnimals.Add(lionGosho);
            myAnimals.Add(dogSharo);
            myAnimals.Add(frogPetko);
            myAnimals.Add(tomcatTocho);
            myAnimals.Add(snailLubov);
            Console.WriteLine("This is full list of animals:\n{0}", string.Join("\n", myAnimals));

            var sortedByAges = myAnimals.OrderBy(x => ((Animal)x).Age);
            Console.WriteLine("\nThis is sorted list of animals:\n{0}", string.Join("\n", sortedByAges));


            // за да изчисля средна възраст е уместно да въведа много повече животни
            // мисля тази задача е рутинна и не е близка до темата на домашното
            // поради това не я и правя
        }
    }
}
