
internal class Program
{
    public static bool CheckForEven(int i)
    {
        return i % 2 == 0;
    }
    public static bool CheckForOdd(int i)
    {
        return i % 2 == 1;
    }
    public delegate bool CheckFunction(int n);

    public static void ProcessList(int[] list, CheckFunction cf)
    {
        foreach (int i in list)
        {
            if (cf(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Delegate Investigation");

        int[] list = { 1, 4, 3, 5, 6, 8, 7, 10, 9, 3, 2, 1 };

        Console.WriteLine("Odd numbers:");
        ProcessList(list, CheckForOdd);


        Console.WriteLine("Even numbers:");
        ProcessList(list, i => i % 2 == 0);





    }
}