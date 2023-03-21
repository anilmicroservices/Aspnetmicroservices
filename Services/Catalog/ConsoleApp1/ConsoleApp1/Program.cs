using System;

class AnagramChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first word: ");
        string word1 = Console.ReadLine();

        Console.Write("Enter the second word: ");
        string word2 = Console.ReadLine();

        if (IsAnagram(word1, word2))
        {
            Console.WriteLine("{0} and {1} are anagrams.", word1, word2);
        }
        else
        {
            Console.WriteLine("{0} and {1} are not anagrams.", word1, word2);
        }

        Console.ReadLine();
    }

    static bool IsAnagram(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        char[] chars1 = word1.ToLower().ToCharArray();
        char[] chars2 = word2.ToLower().ToCharArray();

        //Array.Sort(chars1);
        //Array.Sort(chars2);

        for (int i = 0; i < chars1.Length; i++)
        {
            if (chars1[i] == chars2[i])
            {
                return false;
            }
        }

        return true;
    }
}
