using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.AbstractExample
{
    class Tiger : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("tiger roar");
        }

        public override void animalMovement()
        {
            Console.WriteLine("tiger runs");
        }

        public override void animalSleeps()
        {
            Console.WriteLine("test");
        }
    }
}
