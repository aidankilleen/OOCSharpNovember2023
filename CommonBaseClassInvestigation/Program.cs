using CommonBaseClassInvestigation;

Console.WriteLine("Common Base Class - Investigation");

// regular instantiation of an object using a constructor
Member m = new Member(1, "alice", "alice@gmail.com", true);

Console.WriteLine(m);


// c# instantiation of an object by initialising the properties
// this only works if there is a default constructor
Member m2 = new Member
{
    Id = 2,
    Name = "Bob",
    Email = "bob@gmail.com",
    IsActive = true
};

Member m3 = new Member
{
    Id = 2,
    Name = "Bob",
    Email = "bob@gmail.com",
    IsActive = true
};

//m3 = m2;  // this would make both variable refer to the exact same obj

Console.WriteLine(m2);
Console.WriteLine(m3);

if (m2.Equals(m3))
{
    Console.WriteLine("Same");
} else
{
    Console.WriteLine("Different");
}


Console.WriteLine(m2.GetHashCode());
Console.WriteLine(m3.GetHashCode());



string name = "Aidan";

string name2 = "Aidan";

if (name.Equals(name2))
{
    Console.WriteLine("same");
} else
{
    Console.WriteLine("different");
}



Object[] items =
{
    new Member(1, "Alice", "alice@gmail.com", false),
    "this is a string",
    DateTime.Now,
    1234
};

foreach (Object item in items)
{
    Console.WriteLine(item.GetType().Name);
}








