using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInvestigation
{
    internal class GarbageCollectionInvestigation
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Garbage Collection Investigation");

            for (int i=1; i<10000; i++)
            {
                Message m = new Message { Title = $"Message {i}", Text = $"This Is Mssage {i}" };

            }


        }
    }
}
