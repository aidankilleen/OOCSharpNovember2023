using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInvestigation
{
    internal class Member
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Testing the member class");
        }

    }
}
