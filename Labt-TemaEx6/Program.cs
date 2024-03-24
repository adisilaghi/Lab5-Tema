/*Ex 6
Screiti un program care va numara vocalele dintr-un sir de caractere citit de
la tastatura.*/

Console.WriteLine("Enter a sentence");
string sentence = Console.ReadLine().ToLower();

int total = 0;
var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

for (int i = 0; i < sentence.Length; i++)
{
    if (vowels.Contains(sentence[i]))
    {
        total++;
    }
}
Console.WriteLine("Your total number of vowels in the sentence is: {0}", total);

Console.ReadLine();