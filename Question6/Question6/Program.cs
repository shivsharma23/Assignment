Console.WriteLine("ENTER STRING:");
string x = Console.ReadLine();
string z = "";
for(int i = (x.Length)-1; i >= 0; i--)
{
    z = z + x[i];
}
Console.WriteLine(z);