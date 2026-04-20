namespace epstein_files_csharp_edition;

class Program
{
    static void Main(string[] args)
    {
        int number1 = Console.ReadLine();
        int number2 = Console.ReadLine();
        int number3 = Console.ReadLine();
        int number4 = Console.ReadLine();
        int number5 = Console.ReadLine();
        int list[] = { number1, number2, number3, number4, number5 };
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
        cout << $"Max: {max}\nMin: {min}";
        cout << $"The full multiplication product is: {number1 * number2 * number3 * number4 * number5}";
    }
