using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public delegate void EventsKeyPress(char key);

    class EventsExample
    {
        public event EventsKeyPress KeyClick;
        public void Start()
        {
            Console.WriteLine("Running!");
            while (true)
            {
                char charKey = Console.ReadKey(true).KeyChar;
                if (KeyClick != null)
                {
                    KeyClick(charKey);
                }
                if (charKey == 'q')
                {
                    //KeyClick?.Invoke(charKey);
                    break;
                }
                //KeyClick?.Invoke(charKey);
            }
        }
    }
}
