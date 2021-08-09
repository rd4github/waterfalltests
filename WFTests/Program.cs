using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFTests.Zoo;

namespace WFTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo<IAnimal> newZoo = new Zoo<IAnimal>(5);
            Animal animal1 = new Tiger("Bengal Tiger 001");
            Animal animal2 = new Elephant("African Elephant 001");
            Animal animal3 = new Gorilla("Amazon Gorilla 001");
            Animal animal4 = new Monkey("SriLankan Monkey 001");
            Animal animal5 = new PolarBear("North Pole Polarbear 001");

            newZoo.BuildZoo(animal1);
            newZoo.BuildZoo(animal2);
            newZoo.BuildZoo(animal3);
            newZoo.BuildZoo(animal4);
            newZoo.BuildZoo(animal5);

            foreach(Animal animal in newZoo.Animals.Animals)
            {
                Console.WriteLine($"Zoo has {animal.Name}");
            }


            animal1.Feed(1);
            Console.WriteLine($"Zoo animal {animal1.Name} is still hungy : {animal1.StillHungry} and lives at {animal1.HomeEnviornment}");
            Console.WriteLine($"Zoo animal {animal3.Name} says : {animal3.SayHello()}");

            Console.WriteLine($"Zoo has {newZoo.Animals.AnimalsCount} animals ");

            newZoo.RemoveOneAnimalFromZoo();

            Console.WriteLine($"Now Zoo has {newZoo.Animals.AnimalsCount} animals ");

            Console.Read();
        }
    }
}
