using System.Diagnostics.Tracing;

namespace reverse_vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Leetcode";


            string result = ReverseVowel(word);


            Console.WriteLine(result);
        }

        public static string ReverseVowel(string word)
        {
            HashSet<char> vowels = new HashSet<char>()
        {
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
        };

            char[] characters = word.ToCharArray();
            int i = 0;
            int j = word.Length - 1;

            while (i < j)
            {
                
                while (i < j && !vowels.Contains(characters[i]))
                {
                    i++;
                }
                while (i < j && !vowels.Contains(characters[j]))
                {
                    j--;
                }
                char temp = characters[i];
                characters[i++] = characters[j];
                characters[j--] = temp;   
            }

            return new string(characters);
        }
    }
}