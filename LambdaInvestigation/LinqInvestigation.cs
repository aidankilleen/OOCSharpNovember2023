using MemberDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaInvestigation
{
    internal class LinqInvestigation
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Linq Investigation");

            MemberDao.MemberDao dao = new MemberDao.MemberDao();

            var members = dao.GetMembers();


            var result = from member in members 
                         orderby member.Name descending 
                         where member.Active 
                         select member ;




            foreach(Member member in result)
            {
                Console.WriteLine(member);
            }







            dao.Close();


        }
    }
}
