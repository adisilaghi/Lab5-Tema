/*Ex 3
Scrieti un program care va numara toate aparitiile unui caracter intr-un sir
de caractere. Atat caracterul cautat cat si sirul de caractere vor fi citite de la
tastatura*/


Console.WriteLine("Enter string:");
string text = Console.ReadLine();


Console.WriteLine("Enter string:");
char n = char.Parse(Console.ReadLine());


int count(string text, char n)
{
    int res = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == n)
            res++;
    }

    return res;

}
Console.WriteLine(count(text, n));
