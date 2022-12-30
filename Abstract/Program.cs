using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dog dog = new Dog();
            dog.Eat();

            Horse horse = new Horse();
            horse.Eat();
        }
    }
}
