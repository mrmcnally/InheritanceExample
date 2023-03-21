using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Car : IVehicle
    {
        private string name;
        private int numberOfPassengers;
        private string engineType;
        private int topSpeed;

        public string Name 
        {
            get { return name; }
            set { name = value; }

        }
        public int NumberOfPassengers 
        {
            get { return numberOfPassengers; }
            set { numberOfPassengers = value; }
        }
        public string EngineType 
        {
            get { return engineType; }
            set { engineType = value; }
        }
        public int TopSpeed 
        {
            get { return topSpeed; }
            set { topSpeed = value; }
        }

        public void getDetails()
        {
            Console.WriteLine("Name: {0}   No of Passengers: {1} ... etc", Name, NumberOfPassengers);
        }

        public string passengersToString()
        {
            return NumberOfPassengers.ToString();
        }
    }
}
