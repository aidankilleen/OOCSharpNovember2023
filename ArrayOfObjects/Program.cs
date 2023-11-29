using ArrayOfObjects;

Console.WriteLine("Array Of Objects");


Member m = new Member { 
    Id=1, 
    Name="Alice", 
    Email="alice@gmail.com", 
    IsActive=true 
};


Member[] members =
{
    new Member { Id=1, Name="Alice", Email="alice@gmail.com", IsActive=true },
    new Member { Id=2, Name="Bob", Email="bob@gmail.com", IsActive=false },
    new Member { Id=3, Name="Carol", Email="carol@gmail.com", IsActive=true },
    new Member { Id=4, Name="Dan", Email="dan@gmail.com", IsActive=false },
    new Member { Id=5, Name="Eve", Email="eve@gmail.com", IsActive=false }
};


foreach(Member member in members)
{
    member.Display();
}



/*
for (int i=0; i<members.Length; i++)
{
    Console.WriteLine(members[i].Name);
}
*/



