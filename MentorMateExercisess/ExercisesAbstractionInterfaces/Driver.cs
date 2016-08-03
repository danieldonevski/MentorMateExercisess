using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    public delegate void CommandGiven(string command, Vehicle car, Vehicle truck,ref bool vehicleChoosen,ref int vehicle);
    public class Driver
    {
        public event CommandGiven Command;

        Vehicle car = new Car(1908, "Audi");
        Vehicle truck = new Truck(2008, "MAN");
        public void Run()
        {

            bool vehicleChoosen = false;
            int vehicle = -1;
         
            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (Command != null)
                {
                    Command(command,car,truck,ref vehicleChoosen,ref vehicle);
                }
            }
        }

    }
}
