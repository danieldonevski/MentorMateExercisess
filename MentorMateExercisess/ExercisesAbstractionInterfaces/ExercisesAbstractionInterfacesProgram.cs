using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    enum Vehicles { car, truck};
    class ExercisesAbstractionInterfacesProgram
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            driver.Command += OnCommand;
            Console.WriteLine("Choose a vehicle(\"car\", \"truck\"):");
            driver.Run();
           

        }
        static void OnCommand(string command, Vehicle car, Vehicle truck, ref bool vehicleChoosen, ref int vehicle)
        {
            if (vehicleChoosen == false)
            {
                if (command == "car")
                {
                    vehicleChoosen = true;
                    vehicle = (int)Vehicles.car;
                    Console.WriteLine("Choose a command start/stop/accelerate/decelerate/new:");
                    
                }
                else if (command == "truck")
                {
                    vehicleChoosen = true;
                    vehicle = (int)Vehicles.truck;
                    Console.WriteLine("Choose a command start/stop/accelerate/decelerate/new:");

                }
                else
                {
                    Console.WriteLine("Choose a vehicle(\"car\", \"truck\"):");
                }
            }
            else
            {
              
                switch (vehicle)
                {
                    case (int)Vehicles.car:
                        switch (command)
                        {
                            case "start":
                                car.Start();
                                break;
                            case "stop":
                                car.Stop();
                                break;
                            case "accelerate":
                                car.Accelerate();
                                break;
                            case "decelerate":
                                car.Decelerate();
                                break;
                            case "new":
                                vehicle = -1;
                                vehicleChoosen = false;
                                if (car.Moving)
                                {
                                    car.Stop();
                                }
                                break;
                                default:
                                Console.WriteLine("start/stop/accelerate/decelerate/new");
                                    break;
	                        }
                        break;
                    case (int)Vehicles.truck:
                        switch (command)
                        {
                            case "start":
                                truck.Start();
                                break;
                            case "stop":
                                truck.Stop();
                                break;
                            case "accelerate":
                                truck.Accelerate();
                                break;
                            case "decelerate":
                                truck.Decelerate();
                                break;
                            case "new":
                                vehicle = -1;
                                vehicleChoosen = false;
                                if (truck.Moving)
                                {
                                    truck.Stop();
                                }
                                break;
                            default:
                                Console.WriteLine("start/stop/accelerate/decelerate/new");
                                break;
                        }
                        break;
                }
            }

        }
    }
}
