using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExercises
{
    class GenericExercisesProgram
    {
        static void Main(string[] args)
        {
            GenericList<string> myGeneric = new GenericList<string>();
            for (int i = 0; i < 121; i++)
            {
                myGeneric.Add("haha");
            }
            for (int i = 0; i < 20; i++)
            {
                myGeneric.RemoveAt(i);
                
            }

            //foreach (var item in myGeneric)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < myGeneric.Size; i++)
            {
                Console.WriteLine(i + myGeneric[i]);
            }
        }
    }
}
