// Building block #1 = comments
// Single line comment

/*
 * Multi-line comment
 */


using System.Security.AccessControl;

Console.WriteLine("Hello, World!");  // comment at the end of a line


// Building Block #2 - Variables

int a = 10;
double d = 9.987654;
string s = "this is a string";


// a = "ten";

// Building Block #3 - Expressions

int answer = a + 100;
Console.WriteLine("The answer is " + answer);
double ans = a + 100 / d;
Console.WriteLine("The answer is " + ans);


// Building Block # 4 - loops
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

int j = 0;
while (j < 10)
{
    Console.WriteLine(j);
    j++;
}

// aside - create a random number

Random rg = new Random();

int r = rg.Next(10);
Console.WriteLine("r=" + r);


// Building Block #5 - Conditions
if (r < 4)
{
    Console.WriteLine("r is small");
} else if (r < 7)
{
    Console.WriteLine("r is medium");
} else
{
    Console.WriteLine("r is big");
}


// ternary operator
Console.WriteLine(r + " is " + (r < 5 ? "small" : "big"));

// is equivalent to this:
if (r<5)
{
    Console.WriteLine(r + " is small");
} else
{
    Console.WriteLine(r + " is big");
}

// Building Block # 6 array - list

int[] list = { 1, 6, 4, 3, 8, 9, 6, 2, 0 };

Console.WriteLine(list.Length);

Console.WriteLine(list[1]); // array index starts at 0 so this is the second element
Console.WriteLine(list[0]); // this is the first element

Console.WriteLine("==========================");
for (int n = 0; n < list.Length; n++)
{
    Console.WriteLine(list[n]);
}

// Building Block #7 - Functions
Console.WriteLine("Writeline is a function");

// function has a name
// function has a parameter list 
// function often returns a value
// functions can be "overloaded" i.e. different versions usually with different parameters
// parameters and return value are strongly typed

// rg.Next("can't take a string");

r = rg.Next();
Console.WriteLine(r);

r = rg.Next(10);
Console.WriteLine(r);

r = rg.Next(10, 100);
Console.WriteLine(r);



// Building Block #8 - Objects
// an object is a programming construct that groups together 
// the data for a concept
// along with the functions needed by the concept
// into a reusable entity.

string name = "aidan";

Console.WriteLine(name);
Console.WriteLine(name.Length);
Console.WriteLine(name.ToUpper());




























































