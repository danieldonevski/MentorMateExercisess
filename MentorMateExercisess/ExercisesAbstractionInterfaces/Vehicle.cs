using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesAbstractionInterfaces
{
    public abstract class Vehicle : IVehicle, IMoveable
    {

        private int year;
        private string model;
        private bool moving;

        public Vehicle(int year, string model)
        {
            Year = year;
            Model = model;
            
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (!(value > 1900 && value < 2017))
                {
                    throw new Exception("Invalid year!");
                }
                year = value;

            }
        }

        public string Model { get; set; }

        public bool Moving { get; set; }

        public abstract void Accelerate();

        public abstract void Decelerate();

        public abstract void Start();

        public abstract void Stop();
        
    }
}
