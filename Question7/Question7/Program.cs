Console.WriteLine("ENTER STRING:");
string x = Console.ReadLine();
char[] arr = new char[x.Length];
for (int i = 0; i < x.Length; i++)
{
    arr[i] = x[i];
}
int n=arr.Length;
for (int i=0; i < n; i++)
{
    if (i == 0)
    {
        arr[0] = Char.ToUpper(arr[0]);
    }
    if (i ==n-1)
    {
        arr[n - 1] = Char.ToUpper(arr[n-1]);
    }
    if (arr[i]==' ')
    {
        arr[i + 1] = Char.ToUpper(arr[i + 1]);
        arr[i - 1] = Char.ToUpper(arr[i - 1]);
    }
}
string z = new string(arr);
Console.WriteLine(z);