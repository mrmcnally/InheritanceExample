using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Dog : Animal
    {
        private string breed;

        //Constructor passes name to base and sets breed field
        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        //Overriding base method
        public override void makeSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
