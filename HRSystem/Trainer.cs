using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    internal class Trainer : Employee, ITeacher
    {
        public Trainer(string firstName, 
                        string lastName, 
                        string employeeId) 
            : base(firstName, lastName, employeeId)
        {
        }

        public void Teach()
        {
            Console.WriteLine("Sit up and listen, lesson about to start...");
        }
    }
}
