namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Horizontal or vertical? (h/v) > ");
        string horv = Console.ReadLine();
        Console.Write("Enter length (number) > ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Enter the symbol to use > ");
        char symbol = char.Parse(Console.ReadLine());

        for (int i = 0; i < length; i++)
        {
            if (horv == "v")
            {
                Console.WriteLine(symbol);
            }
            else
            {
                Console.Write(symbol);
            }
        }
    }
}
