using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTests.Zoo
{
    abstract class Animal : IAnimal
    {
        public abstract double Height { get; }
        public abstract Habitats HomeEnviornment { get; }
        public abstract string Name { get; }
        public abstract bool StillHungry { get; }
        public abstract void Feed(int foodQuntity);
        public abstract string SayHello();

    }
}
