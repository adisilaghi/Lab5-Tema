/*Ex 4
Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
de la tastatura, ignorand caseing-ul literelor.
Exemplu:
Input: Elena are mere
Output: e apare de 5 ori
*/

Console.WriteLine("Enter string:");
string text = Console.ReadLine();

Dictionary<char, int> mostFrequentChars = GetMostFrequentChar(text);

Console.WriteLine("Most frequent character(s) and their count:");
foreach (var most in mostFrequentChars)
{
    Console.WriteLine($"Character: {most.Key}, Count: {most.Value}");
}
    

    static Dictionary<char, int> GetMostFrequentChar(string text)
{
    text = text.ToLower();
    Dictionary<char, int> chars = new Dictionary<char, int>();
    
    foreach (char c in text)
    {
        if (chars.ContainsKey(c))
            chars[c]++;
        else
            chars.Add(c, 1);
    }
    
    int max = chars.Values.Max();

    
    Dictionary<char, int> mostFrequentChars = chars
        .Where(pair => pair.Value == max)
        .ToDictionary(pair => pair.Key, pair => pair.Value);

    return mostFrequentChars;
}



