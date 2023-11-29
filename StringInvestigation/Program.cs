Console.WriteLine("String Investigation");

string name = "Aidan";

Console.WriteLine(name);
Console.WriteLine(name.ToUpper());
Console.WriteLine(name);

string message = "this is a message";
Console.WriteLine(message);

// escape sequence - \n = new line character
message = "this\nis\na\nmultiline\nstring";
Console.WriteLine(message);

message = "Press the \"red\" button";
Console.WriteLine(message);

string filename = "C:\\my documents\\training\\file.txt";
Console.WriteLine(filename);

int a = 10;
int b = 3;

Console.WriteLine(a + " + " + b + " = " + (a + b));

// conversion using a cast
double answer = (double)a / b;

answer = 3;

Console.WriteLine(String.Format("{0:0.00}", answer));

// templated strings have superceeded String.Format in a lot of places

message = $"Welcome { name }";

Console.WriteLine(message);


message = $"{ a } + { b } = { a + b}";

Console.WriteLine(message);


// Raw strings

message = @"raw strings don't respect the escape characters\n\n";

Console.WriteLine(message);

filename = @"C:\program files\my documents\file1.txt";

Console.WriteLine(filename);


message = @"Raw strings
can span
multiple lines";

Console.WriteLine(message);


message = $@"
  {a}
+  {b}
--------
  {a + b}";

Console.WriteLine(message);
















