using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Cat : Animal
    {
        private string breed;

        //Cat constructor takes name and breed as arguments and passes name to base class
        public Cat(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        //Make sound method overrides base class method using override keyword
        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
