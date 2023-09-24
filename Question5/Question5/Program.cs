Console.WriteLine("ENTER STRING:");
string x = Console.ReadLine();
char c;
for(int i = 0; i < x.Length; i++)
{
    c = x[i];
    if (Char.IsLetter(c))
    {

    }
    else
    {
        x = x.Replace(Char.ToString(c), String.Empty);
    }
}
Console.WriteLine(x);