using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Animal
    {
        protected string name;

        //Constructor
        public Animal(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Make sound method
        public virtual void makeSound()
        {
            Console.WriteLine("Animal Noises");
        }

    }
}
