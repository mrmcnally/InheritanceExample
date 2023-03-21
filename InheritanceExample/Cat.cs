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

        public Cat(string name, string breed) : base(name)
        {

        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }


    }
}
