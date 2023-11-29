using MemberDao;

Console.WriteLine("Shared Project Investigation");

MemberDao.MemberDao dao = new MemberDao.MemberDao();

try
{
    Member member = dao.GetMember(999);
    Console.WriteLine(member);
} catch(MemberDaoException ex)
{
    Console.WriteLine(ex.Message);
}





List<Member> members = dao.GetMembers();

foreach (Member m in members)
{
    Console.WriteLine(m);
}

dao.Close();
