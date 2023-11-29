using ExceptionInvestigation;
using System.Text.Json.Serialization;

Console.WriteLine("Exception Investigation");
int a = 10;
int b = 0;
int[] list = { 1, 2, 3, 4 };
string name = null;

int answer=-1;
Random rg = new Random();
int r = rg.Next(5);

try
{
    if (r == 0)
    {
        answer = list[4];
    } else if (r == 1)
    {
        answer = a / b;
    } else if (r == 2)
    {
        answer = name.Length;
    } else if (r == 3)
    {
        throw new MyCustomException("Custom Exception thrown");
    }
    else
    {
        // no error 
        answer = 99;
    }
} catch(IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
    answer = list[0];
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
    answer = 0;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    answer = 0;
}
finally
{
    // this code gets executed if there is an exception or not
    Console.WriteLine($"Answer: { answer }");
}



Console.WriteLine("Finished");







/* glass is half full approach
try
{
    DoSomething();
    DoSomethingElse();

} catch (FileException)
{

} catch(NetworkException)
{

}
catch (ParameterException)
{

}

// everything ok
*/





/* glass is half empty
int r = DoSomething();
if (r == -1)
{
    // file error
} else if (r == -2)
{
    // network error
} else if (r == -3)
{
    // parameter error
} else
{
    // everything ok
}
r = DoSomethingElse();
if (r == -1)
{
    // file error
}
else if (r == -2)
{
    // network error
}
else if (r == -3)
{
    // parameter error
}
else
{
    // everything ok
}
*/

