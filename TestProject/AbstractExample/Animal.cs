using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.AbstractExample
{
    abstract class Animal
    {
        public abstract void animalSound();
        public abstract void animalMovement();

        public virtual void animalSleeps()
        {
            Console.WriteLine("Tiger Sleeps");
        }
    }
}
