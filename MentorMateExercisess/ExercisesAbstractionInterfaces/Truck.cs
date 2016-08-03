using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    class Truck : Vehicle
    {
        public Truck(int year,string model) 
            :base(year, model)
        {
            
        }

        public override void Accelerate()
        {
            if (Moving == true)
            {
                Console.WriteLine("The truck {0} Accelerated!", Model);
            }
            else
            {
                Console.WriteLine("The truck {0} is not started!", Model);
            }
        }

        public override void Decelerate()
        {
            if (Moving == true)
            {
                Console.WriteLine("The truck {0} Decelerated!", Model);
            }
            else
            {
                Console.WriteLine("The truck {0} is not started!", Model);
            }
        }

        public override void Start()
        {
            if (Moving != true)
            {
                Console.WriteLine("The truck {0} Started!", Model);
                Moving = true;

            }
            else
            {
                Console.WriteLine("The truck {0} is already Started!", Model);
            }
         }

    public override void Stop()
        {
            if (Moving == true)
            {
                Console.WriteLine("The truck {0} Stoped!", Model);
                Moving = false;
            }
            else
            {
                Console.WriteLine("The truck {0} is already Stoped!", Model);
            }
        }
    }
}
