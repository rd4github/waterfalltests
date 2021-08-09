using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTests.Zoo
{
    public interface IAnimal
    {
        /// <summary>
        /// Name of the animal
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Home enviornment for Animal
        /// </summary>
        Habitats HomeEnviornment { get; }
        /// <summary>
        /// Is Animal still hungry
        /// </summary>
        bool StillHungry { get; }
        void Feed(int foodQuntity);
        string SayHello();
        
    }
}
