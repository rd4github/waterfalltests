using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTests.Zoo
{
    interface IZooAnimals<T>
    {
        int AnimalsCount { get; }
        int AddAnimalToZoo(T animal);
        bool RemoveAnimalFromZoo(int animalKey);
        IList<T> Animals { get; }
    }
}
