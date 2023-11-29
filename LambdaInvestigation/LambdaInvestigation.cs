using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LambdaInvestigation
{
    internal class LambdaInvestigation
    {
        public static void MyAction(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Investigation");

            List<int> list = new List<int>{ 1, 4, 3, 5, 2, 6, 8, 9, 7, 12, 11, 10 };

            list.ForEach(MyAction);

            Console.WriteLine("-----------------------------------");
            list.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("-----------------------------------");
            var evenNumbers = list.FindAll((i) =>
            {
                if (i % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            evenNumbers.ForEach(no => Console.WriteLine(no));


            Console.WriteLine("-----------------------------------");
            var oddNumbers = list.FindAll(i => i % 2 == 1);

            oddNumbers.ForEach(no => Console.WriteLine(no));













        }
    }
}
