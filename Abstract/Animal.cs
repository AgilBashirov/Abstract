using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Abstract constructor ishe dushdu.");
        }
        public abstract void Eat();
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Dog");
        }
    }
    class Horse : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Horse");

        }
    }


}
