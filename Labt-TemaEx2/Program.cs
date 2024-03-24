/*Ex 2
Scrieti un program care sa verifice daca un sir de caractere citit de la
tastatura este sau nu palindrom.*/

Console.WriteLine("Enter string:");
string text = Console.ReadLine();

bool isPalindrome = checkPalindrome(text);

if (isPalindrome)
{
    Console.WriteLine($"Entered string '{text}' is palindrome");
}
else
{
    Console.WriteLine($"Entered string '{text}' is not palindrome");
}
static bool checkPalindrome(string text)
{
    char[] c = text.ToCharArray();
    Array.Reverse(c);
    return new string(c).Equals(text);
}

