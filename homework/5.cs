namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        if (A > B)
        {
            int x = A; A = B; B = x;
        }

        for (int i = A; i <= B; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
