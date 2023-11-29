using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInvestigation
{
    internal class Message
    {
        public string Title { get; set; }
        public string Text { get; set; }

        private string[] buffer = new string[1000];

        public static int Count { get; set; } = 0;
        public Message() {
            Console.WriteLine($"Creating: {Count}");
            Count++;
        }
        ~Message()
        {
            // destructor called when 
            // an object is destroyed
            // (done by the GC)
            Console.WriteLine($"Destroying item {Title} - {Count} remaining");
            Count--;

        }
    }
}
