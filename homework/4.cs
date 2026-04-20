namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int[] Fib = new int[100];
        for (int i = 0; i < Fib.Length; i++)
        {
            if (i == 0 || i == 1)
            {
                Fib[i] = 1;
            }
            else
            {
                Fib[i] = Fib[i - 1] + Fib[i - 2];
            }
        }
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        for (int i = 0; i < Fib.Length; i++)
        {
            if (Fib[i] >= min && Fib[i] <= max)
            {
                Console.WriteLine(Fib[i]);
            }
        }
    }
}
