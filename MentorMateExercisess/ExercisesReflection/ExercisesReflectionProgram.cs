using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesReflection
{
    class ExercisesReflectionProgram
    {
        static void Main(string[] args)
        {
            Assembly currAss = Assembly.GetAssembly(typeof(Character));
            foreach (var type in currAss.GetTypes())
            {
                Console.WriteLine("In Class: {0}",type.Name);
                foreach (var member in type.GetMembers())
                {
                    Console.WriteLine("{0}: {1}",member.MemberType,member.Name);
                }
                Console.WriteLine("------------------");
            }
        }
    }
}
