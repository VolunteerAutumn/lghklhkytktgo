namespace epstein_files_csharp_edition;

class Program
{
    static void Main(string[] args)
    {
        int _6digitnumber = Console.ReadLine();
        char[] charArray = _6digitnumber.ToCharArray();
        charArray.reverse(); // the array has this method already implemented in it.
        string reversed = new string(charArray); // turning it into a string
        Console.WriteLine(reversed);
    }
}
