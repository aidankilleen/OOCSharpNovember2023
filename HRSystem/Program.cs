using HRSystem;

Console.WriteLine("HR System");

List<ITeacher> teachers = new List<ITeacher>
{
    new Trainer("Eve", "Evans", "E33333"),
    new Tutor("Fred", "Flintstone", "Rescon"),
    new Trainer("Ger", "Gogarty", "E12321"),

};

foreach (ITeacher teacher in teachers)
{
    teacher.Teach();


    ((Person)teacher).Display();
}




/*
Trainer trainer = new Trainer("Eve", "Evans", "E33333");

trainer.Teach();

Tutor tutor = new Tutor("Fred", "Flintstone", "Rescon");
tutor.Teach();
*/



/*
Person p = new Person("Alice", "Adams");
p.Display();

Employee e = new Employee("Bob", "Byrne", "E12345");
e.Display();

Contractor c = new Contractor("Carol", "Conway", "CPL");
c.Display();

Manager m = new Manager("Danielle", "Dunne", "E22222", 50);
m.Display();
*/

/*
Person[] team =
{
    new Person("Alice", "Adams"),
    new Employee("Bob", "Byrne", "E12345"),
    new Contractor("Carol", "Conway", "CPL"),
    new Manager("Danielle", "Dunne", "E22222", 50)
};
*/
/*
List<Person> team = new List<Person> {
    new Person("Alice", "Adams"),
    new Employee("Bob", "Byrne", "E12345"),
    new Contractor("Carol", "Conway", "CPL"),
    new Manager("Danielle", "Dunne", "E22222", 50)
};

foreach(Person person in team)
{
    person.Display();
}
*/



