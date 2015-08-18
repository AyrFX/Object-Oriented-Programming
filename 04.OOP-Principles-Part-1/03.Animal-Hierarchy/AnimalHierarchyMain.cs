// Problem 3. Animal hierarchy
// Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All
// animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name
// and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
// Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method
// (you may use LINQ).

namespace Animal_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using Animal_Hierarchy.Classes;

    public class AnimalHierarchyMain
    {
        public static void Main()
        {
            Dog[] dogsArray = new Dog[]
            {
                new Dog("Burk", Sex.Male, 2),
                new Dog("Charlie", Sex.Male, 2),
                new Dog("Sara", Sex.Female, 3),
                new Dog("Abra", Sex.Female, 7)
            };
            
            Frog[] frogsArray = new Frog[]
            {
                new Frog("Froggy", Sex.Male, 2),
                new Frog("Lyagushka", Sex.Male, 5),
                new Frog("Kvak", Sex.Female, 4),
                new Frog("Plyok", Sex.Female, 1)
            };
            
            Cat[] catsArray = new Cat[]
            {
                new Cat("Maca", Sex.Female, 3),
                new Cat("Pisan", Sex.Male, 4),
                new Cat("Kotarana", Sex.Female, 2),
                new Cat("Hurry", Sex.Male, 7)
            };

            Kitten[] kittensArray = new Kitten[]
            {
                new Kitten("Pisana", 4),
                new Kitten("Macka", 2),
                new Kitten("Blacky", 6),
                new Kitten("Browny", 5)
            };

            Tomcat[] tomcatsArray = new Tomcat[]
            {
                new Tomcat("Coder", 2),
                new Tomcat("Dicky", 9),
                new Tomcat("Speedy", 4),
                new Tomcat("Sleepy", 7)
            };

            Console.WriteLine("The average age of all dos is {0} years.", Animal.AverageAge(dogsArray));
            Console.WriteLine("The average age of all frogs is {0} years.", Animal.AverageAge(frogsArray));
            Console.WriteLine("The average age of all cats is {0} years.", Animal.AverageAge(catsArray));
            Console.WriteLine("The average age of all kittens is {0} years.", Animal.AverageAge(kittensArray));
            Console.WriteLine("The average age of all tomcats is {0} years.", Animal.AverageAge(tomcatsArray));
        }
    }
}
