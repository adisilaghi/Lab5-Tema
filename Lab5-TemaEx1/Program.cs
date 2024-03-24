/*Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
siruri de caractere fiind citite de la tastatura*/

Console.WriteLine("Enter string");
string text = Console.ReadLine();

Console.WriteLine("Enter searched substring");
string substring = Console.ReadLine();

int position = FindSubstringPosition(text, substring);

if (position != -1)
{
    Console.WriteLine($"Substring '{substring}' found in {position} in the original string.");
}
else
{
    Console.WriteLine($"Substring '{substring}' not found in the string.");
}
    

    static int FindSubstringPosition(string mainString, string substring)
{
    return mainString.IndexOf(substring);
}