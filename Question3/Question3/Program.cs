internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ENTER STRING:");
        string x = Console.ReadLine();
        x = x.Replace("a", string.Empty).Replace("e", string.Empty).Replace("i", String.Empty).Replace("o", String.Empty).Replace("u", String.Empty);
        Console.WriteLine(x);
    }
}