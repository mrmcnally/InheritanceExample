using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    abstract class Animal
    {
        protected string name;

        //Constructor - this is still required as the derived class constructor invokes it
        public Animal(string name)
        {
            Name = name;
        }

        //A abstract class can still have non-abstract fields, methods and properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //The makeSound() method is not abstract and does not have a method body.
        //It must now be implemented in the derived classes
        public abstract void makeSound();
      
    }
}
