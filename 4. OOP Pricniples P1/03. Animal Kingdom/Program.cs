using System;
using System.Collections.Generic;
using System.Linq;

namespace Animal_Kingdom
{
    class Program
    {
        static void FindAvAge(List<Animal> animalList)
        {
            var groupedAvarage = from animal in animalList
                                 group animal by animal.GetType() into groupedAnimals 
                                 select new {GetType = groupedAnimals.Key, AvarageAge = groupedAnimals.Average(animal => animal.Age)};
            foreach (var animal in groupedAvarage)
            {
                Console.WriteLine(animal);
            }
        }

        static void Main(string[] args)
        {
            List<Animal> animalsList = new List<Animal>(10);
            animalsList.Add(new Dog("Kiro", 18, "male"));
            animalsList.Add(new Kitten("Vicious", 10));
            animalsList.Add(new Tomcat("Frederic", 8));
            animalsList.Add(new Frog("Valerian", 30, "male"));
            animalsList.Add(new Dog("Lora", 2, "female"));
            animalsList.Add(new Kitten("Kerrigan", 15));
            animalsList.Add(new Tomcat("Vlad", 3));
            animalsList.Add(new Frog("Charming", 3, "male"));

            FindAvAge(animalsList);

            foreach (var animal in animalsList)
            {
                animal.Sound();
            }
        }
    }
}