Console.WriteLine("ENTER STRING:");
string x=Console.ReadLine();
string z = "";
for(int i = (x.Length) - 1; i >= 0; i--)
{
    z=z+ x[i];
}
if (z == x)
{
    Console.WriteLine("{0} IS PALINDROME STRING", z);
}
else
{
    Console.WriteLine("{0} IS NOT PALINDROME",x);
}

