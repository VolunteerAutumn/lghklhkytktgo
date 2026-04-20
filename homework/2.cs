namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int number5 = int.Parse(Console.ReadLine());
        int[] list = { number1, number2, number3, number4, number5 };
        Console.WriteLine($"Sum: {number1 + number2 + number3 + number4 + number5}");
        int max = 0;
        foreach (int number in list)
        {
            if (number > max)
            {
                max = number;
            }
        }
        int min = max;
        foreach (int number in list)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Result of the multiplication of the numbers: {number1 * number2 * number3 * number4 * number5}");
    }
}
