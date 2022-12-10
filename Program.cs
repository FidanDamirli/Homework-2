namespace Homework_2;
class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.Write("A ededini daxil edin:");
        a = int.Parse(Console.ReadLine());
        Console.Write("B ededini daxil edin:");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine($"{a}%{b}={a % b}");

        Console.ReadKey();


    }
}

