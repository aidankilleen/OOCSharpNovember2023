using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    internal class Tutor : Contractor, ITeacher
    {
        public Tutor(string firstName, 
                    string lastName, 
                    string agency) 
            : base(firstName, lastName, agency)
        {
        }

        public void Teach()
        {
            Console.WriteLine("Sit down, lesson is starting...");
        }
    }
}
