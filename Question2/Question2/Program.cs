Console.WriteLine("ENTER STRING:");
string x= Console.ReadLine();
int vowels = 0;
int cons = 0;
int spaces = 0;
char c;
for(int i = 0; i < x.Length; i++)
{
    c = x[i];
    if((c== 'a'  || c=='e' || c=='i' || c== 'o' || c=='u') || ( c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'))
    {
        vowels++;
    }
    if(c==' ')
    {
        spaces++;
    }
    if ((c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u') &&(c != 'A' && c != 'E' && c != 'I' && c != 'O' && c != 'U') && (Char.IsNumber(c)==false) && c!=' '   )
    {
   
        cons++;
    }
   
}
Console.WriteLine("NUMBER OF VOWELS:{0}", vowels);
Console.WriteLine("NUMBER OF CONSONENTS:{0}", cons);
Console.WriteLine("NUMBER OF SPACES:{0}", spaces);