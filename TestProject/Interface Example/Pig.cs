using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Interface_Example
{
    class Pig : Animal1, IAnimal2, IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("oink oink");
        }

        public void animalSound2()
        {
            Console.WriteLine("oink");
        }
    }
}
