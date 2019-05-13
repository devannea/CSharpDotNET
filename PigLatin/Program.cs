using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            /* 1. Translate English to Pig Latin
            string convertedWord = ToPigLatin(input);
            Console.WriteLine(convertedWord);
            Console.Read();
            */
            ToPigLatin(input);
            Console.Read();
        }
        public static string ToPigLatin(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int firstVowelPosition = word.IndexOfAny(vowels);
            if (firstVowelPosition == -1)  // check for vowel
            {
                return (word + "ay");
            }
            else
            {
                char firstLetter = word[0]; // first letter
                char lastLetter = word[word.Length - 1]; // last letter
                //word starts with a vowel && ends in a vowel, add "yay"
                if (vowels.Contains(firstLetter) && vowels.Contains(lastLetter))
                {
                    return (word + "yay");
                }
                else
                {
                    // first letter is not a vowel || last letter is not a vowel
                    // split the word at the first vowel 
                    string firstHalf = word.Substring(0, firstVowelPosition);
                    string secondHalf = word.Substring(firstVowelPosition);
                    return (secondHalf + firstHalf + "ay");
                }

            }

        }
    }
}
