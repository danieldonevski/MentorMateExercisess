using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class ExercisesEventsDelegatesProgram
    {
        static void Main(string[] args)
        {
            DelegatesExample delegatesExample = new DelegatesExample();
            //delegatesExample.KeyClick = new KeyPress(OnClick);
            delegatesExample.KeyClick = OnClick;
            //delegatesExample.Start();
            EventsExample EventsExample = new EventsExample();
            EventsExample.KeyClick += OnClick;
            EventsExample.Start();
        }
        static void OnClick(char key)
        {
            Console.WriteLine("Key form the delegate: {0}", key);
        }
    }
}
