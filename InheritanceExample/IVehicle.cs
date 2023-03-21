using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    interface IVehicle
    {
        //interface properties
        string Name { get; set; }
        int NumberOfPassengers { get; set; }
        string EngineType { get; set; }
        int TopSpeed { get; set; }
         
        //interface methods
        void getDetails();
        string passengersToString(); 

    }
}

