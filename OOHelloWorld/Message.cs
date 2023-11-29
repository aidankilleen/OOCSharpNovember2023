using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOHelloWorld
{
    internal class Message
    {
        // member variables
        private string Title { get; set; } = "TITLE";

        private string Text { get; set; } = "TEXT";

        private int _delay = 2000; // how long to wait before showing the message

        // Properties
        public int Delay
        {
            get
            {
                return _delay;
            }
            set
            {
                if (value > 0)
                {
                    _delay = value;

                } else
                {
                    Console.WriteLine("Invalid value");
                }
            }
        }

        // member functions (methods)

        /*
         * Set methods are a Java way of doing this
         * C# uses "Properties"
        public void SetDelay(int delay)
        {
            if (delay > 0)
            {
                this.delay = delay;
            } else
            {
                Console.WriteLine("Invalid data");
            }
        }
        */

        // constructor(s)
        public Message()
        {
        }

        public Message(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public void Display()
        {
            Thread.Sleep(Delay);

            Console.WriteLine(Title);
            Console.WriteLine(Text);
        }
    }
}
