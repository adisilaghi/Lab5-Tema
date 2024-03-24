/*Ex 5
Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
Exemplu:
Input: Ana ARE mErE
Rezultat: Ana Are Mere*/


Console.WriteLine("Enter string:");
string text = Console.ReadLine();

string s = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
Console.WriteLine(s);