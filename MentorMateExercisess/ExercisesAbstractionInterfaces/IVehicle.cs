using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    interface IVehicle
    {
        int Year { get; set; }
        string Model { get; set; }

        //void Drive();
        
        bool Moving { get; set; }


    }
}
