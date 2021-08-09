using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTests.Zoo
{
    class PolarBear : Animal
    {
        bool _hungry;
        string _name;
        public PolarBear(string name)
        {
            _name = name;
        }
        public override double Height => 4.2;
        public override Habitats HomeEnviornment => Habitats.SeaIce;
        public override string Name => _name;
        public override bool StillHungry => _hungry;
        public override void Feed(int foodQuntity)
        {
            _hungry = foodQuntity < 5;
        }

        public override string SayHello()
        {
            return "growling : ahhhhhh aahhhh";
        }
    }
}
