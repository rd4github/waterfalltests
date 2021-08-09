using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTests.Zoo
{
    class Gorilla : Animal
    {
        bool _hungry;
        string _name;
        public Gorilla(string name)
        {
            _name = name;
        }
        public override double Height => 6.2;
        public override Habitats HomeEnviornment => Habitats.Woodland;
        public override string Name => _name;
        public override bool StillHungry => _hungry;
        public override void Feed(int foodQuntity)
        {
            _hungry = foodQuntity < 50;
        }

        public override string SayHello()
        {
            return "growling : grrrr grrrr";
        }
    }
}
