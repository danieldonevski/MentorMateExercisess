using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{

    public delegate void KeyPress(char key);

    class DelegatesExample
    {
        public KeyPress KeyClick;
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
                //KeyClick?.Invoke(charKey);
            }
        }
    }
}
