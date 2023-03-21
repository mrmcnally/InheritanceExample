using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiating an object using the derived class reference
            Dog d1 = new Dog("Derived Dog", "Pug");

            //instantiating an object using the base class reference
            //Animal a1 = new Animal("Random Animal");
            Animal a2 = new Dog("Dog", "Poodle");
            Animal a3 = new Cat("Cat", "Balinese");

            //making sounds
            d1.makeSound();
            //a1.makeSound();
            a2.makeSound();
            a3.makeSound();

            Console.WriteLine("Iterating through Animal Array");
            Animal[] AnimalArray = new Animal[3];
            //AnimalArray[0] = new Animal("Random Animal");
            AnimalArray[1] = new Dog("Dog", "Pug");
            AnimalArray[2] = new Cat("Cat", "Balinese");

            for(int i = 0; i< AnimalArray.Length; i++)
            {
                AnimalArray[i].makeSound();
            }


        }
    }
}
