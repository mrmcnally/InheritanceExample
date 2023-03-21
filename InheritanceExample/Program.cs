using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal a1 = new Animal("Random Animal");
            Animal a2 = new Dog("Dog", "Poodle");
            Animal a3 = new Cat("Cat", "Balinese");

            a1.makeSound();
            a2.makeSound();
            a3.makeSound();

        }
    }
}
