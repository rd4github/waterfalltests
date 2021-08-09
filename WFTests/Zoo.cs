using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTests.Zoo
{
    /// <summary>
    /// Zoo represents a Zoo that will occupy various animals
    /// </summary>
    sealed class Zoo<T> where T : IAnimal
    {
        IZooAnimals<T> _zooanimals;
        IList<int> animalKeys;
        int _zooCapacity;
        public Zoo(int animalsCapacity)
        {
            _zooCapacity = animalsCapacity;
            _zooanimals = new ZooAnimals<T>(animalsCapacity);
            animalKeys = new List<int>(animalsCapacity);
        }

        public IZooAnimals<T> Animals => _zooanimals;

        public bool BuildZoo(T animal)
        {
            if (_zooanimals.AnimalsCount < _zooCapacity)
            {
                animalKeys.Add(_zooanimals.AddAnimalToZoo(animal));
                return true;
            }
            return false;
        }
        public bool RemoveOneAnimalFromZoo()
        {
            int key = animalKeys.FirstOrDefault();
            return _zooanimals.RemoveAnimalFromZoo(key);
        }
    }
}
