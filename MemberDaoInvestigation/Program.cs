using MemberDao;

Console.WriteLine("MemberDao Investigation");


MemberDao dao = new MemberDao();

var memberToChange = dao.GetMember(1);
memberToChange.Name = "Alice";
memberToChange.Email = "alice@gmail.com";
memberToChange.Active = !memberToChange.Active;
dao.UpdateMember(memberToChange);


Member newMember = new Member
{
    Name = "New Member",
    Email = "new.member@gmail.com",
    Active = false
};
Console.WriteLine(newMember); // no Id

Member addedMember = dao.AddMember(newMember);


Console.WriteLine(addedMember); // Id filled in









var members = dao.GetMembers();
foreach(Member member in members)
{
    Console.WriteLine(member);
}

dao.DeleteMember(4);



Member mbr = dao.GetMember(4);

Console.WriteLine(mbr);
dao.Close();

