using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    internal class Member
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public bool IsActive { get; set; } = false;


        public void Display()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Email);
            Console.WriteLine(IsActive ? "Active" : "Inactive");
        }
    }
}
