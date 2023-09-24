Console.WriteLine("ENTER STRING:");
string x=Console.ReadLine();
string[] arr = x.Split(new char[] { ' ' });
int index=0;
int maxlen = 0;
for(int i=0;i<arr.Length; i++)
{
    if (arr[i].Length > maxlen)
    {
        index = i;
    }
}
Console.WriteLine(arr[index]);