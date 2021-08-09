using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTests.Zoo
{
    class ZooAnimals<T>:IZooAnimals<T> where T : IAnimal
    {
        IDictionary<int,T> _animals;
        public ZooAnimals(int capacity)
        {
            _animals = new Dictionary<int, T>(capacity);
        }

        public int AnimalsCount => _animals.Count;

        public IList<T> Animals => _animals.Values.ToList();
        public int AddAnimalToZoo(T animal)
        {
            int key = BitConverter.ToInt32(Guid.NewGuid().ToByteArray(),0);
            _animals.Add(key, animal);
            return key;
        }

        public bool RemoveAnimalFromZoo(int animalKey)
        {
            if (_animals.ContainsKey(animalKey)) return _animals.Remove(animalKey);
            return false;
        }
    }
}
