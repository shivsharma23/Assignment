Console.WriteLine("ENTER STRING:");
string x=Console.ReadLine();
Console.WriteLine("ENTER  SECOND STRING:");
string y = Console.ReadLine();
char[] x1 = x.ToCharArray();
char[] y1 = y.ToCharArray();
Array.Sort(x1);
Array.Sort(y1);
string x2 = new string(x1);
string y2 = new string(y1);
if (x2.Equals(y2))
{
    Console.WriteLine("TRUE");
}
else
{
    Console.WriteLine("FALSE");
}