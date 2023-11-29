using GenericListInvestigation;
using System.Collections;

Console.WriteLine("Generic List Investigation");

// arrays are fixed in size - we can't easily add or remove items
int[] list = new int[50];

Console.WriteLine(list.IsFixedSize);


ArrayList list2 = new ArrayList();

list2.Add("Alice");
list2.Add("Bob");
list2.Add("Carol");
list2.Add("Dan");

Console.WriteLine(list2.IsFixedSize);


ArrayList members = new ArrayList();

members.Add(new Member { Id=1, Name = "Alice", Email="alice@gmail.com", IsActive=false });
members.Add(new Member { Id = 2, Name = "Bob", Email = "bob@gmail.com", IsActive = false });
members.Add(new Member { Id = 3, Name = "Carol", Email = "carol@gmail.com", IsActive = true });
members.Add(new Member { Id = 4, Name = "Dan", Email = "dan@gmail.com", IsActive = false });
// members.Add("not type safe - so you can add anything to it");


foreach(Member m in members)
{
    Console.WriteLine(m.Name);
}

// type-safe list using Generics
Console.WriteLine("=====================================");

List<Member> tslist = new List<Member>();


tslist.Add(new Member { Id = 1, Name = "Alice", Email = "alice@gmail.com", IsActive = false });
tslist.Add(new Member { Id = 2, Name = "Bob", Email = "bob@gmail.com", IsActive = false });
tslist.Add(new Member { Id = 3, Name = "Carol", Email = "carol@gmail.com", IsActive = true });
tslist.Add(new Member { Id = 4, Name = "Dan", Email = "dan@gmail.com", IsActive = false });

// tslist.Add("this is typesafe and won't accept a string");

foreach(Member member in tslist)
{
    Console.WriteLine(member.Name);
}








