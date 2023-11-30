using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MemberDao;

namespace LambdaInvestigation
{
    internal class ObjectListOperation
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Object List Operations");

            var dao = new MemberDao.MemberDao();

            var members = dao.GetMembers();

            members.ForEach(member => Console.WriteLine(member));

            Console.WriteLine("Active Members");
            var activeMembers = members.FindAll((member) =>
            {
                if (member.Active == true)
                {
                    return true;
                } else
                {
                    return false;
                }
            });

            // much shorter version of the same logic above
            activeMembers = members.FindAll(member => member.Active);

            activeMembers.ForEach(member => Console.WriteLine(member));


            Console.WriteLine("Inactive Members:");
            // chain the operations together
            members.FindAll(member => !member.Active)
                    .ForEach(member => Console.WriteLine(member));

            Console.WriteLine("Sorted:");

            //IOrderedEnumerable<Member> sorted = members.OrderBy(member => member.Name);
            var sorted = members.OrderBy(member => member.Name);

            foreach (Member member in sorted)
            {
                Console.WriteLine(member);
            }

            Console.WriteLine("Active Members in reverse order by name");
            var result = members.Where(member => member.Active)
                    .OrderBy(member => member.Name)
                    .Reverse();


            foreach(Member member in result)
            {
                Console.WriteLine(member);
            }

            



            dao.Close();


        }
    }
}
