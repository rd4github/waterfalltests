using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTests.Zoo
{
    class Elephant : Animal
    {
        bool _hungry;
        string _name;
        public Elephant(string name)
        {
            _name = name;
        }
        public override double Height => 12.0;
        public override Habitats HomeEnviornment => Habitats.Forest;
        public override string Name => _name;
        public override bool StillHungry => _hungry;
        public override void Feed(int foodQuntity)
        {
            _hungry = foodQuntity < 100;
        }

        public override string SayHello()
        {
            return "growling : hhmmmmm hmmmmmm";
        }
    }
}
