namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int _6digitnumber = int.Parse(Console.ReadLine());
        string reversed = new string(_6digitnumber.ToString().Reverse().ToArray());
        Console.WriteLine(reversed);
    }
}
