using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListInvestigation
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        // usually a good idea to have a default constructor
        public Member()
        {
        }

        public Member(int id,
                      string name,
                      string email,
                      bool isActive)
        {
            Id = id;
            Name = name;
            Email = email;
            IsActive = isActive;
        }

        public override string? ToString()
        {
            return $"{Id}-{Name}-{Email}-{(IsActive ? "Active" : "Inactive")}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Member member &&
                   Id == member.Id &&
                   Name == member.Name &&
                   Email == member.Email &&
                   IsActive == member.IsActive;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Email, IsActive);
        }
    }
}
