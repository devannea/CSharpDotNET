using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        public static void Main(string[] args)
        {
        PigLatin();
        }

        // pig latin function goes here
        public static void PigLatin(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            bool startWithVowel = false;
            bool endWithVowel = false;
            bool foundVowel = false;
            string currentVowel = "";
            for (int i = 0; i < vowels.Length - 1; i++)
            {
                string currentVowel = vowels[i].ToString();
                if(word.StartsWith(currentVowel))
                {
                    startWithVowel = true;
                    break;
                }
            }
            for (int i = 0; i < vowels.Length - 1; i++)
            {
                string currentVowel = vowels[i].ToString();
                if (word.EndsWith(currentVowel))
                {
                    endWithVowel = true;
                    break;
                }
            }
            for (int i = 0; i < vowels.Length - 1; i++)
            {
                string currentVowel = vowels[i].ToString();
                if (word.IndexOfAny(vowels)>=1)
                {
                    foundVowel = true;
                }
                StringBuilder sb = new StringBuilder();
                if(startWithVowel && endWithVowel)
                {
                    return (word + "yay");
                }
                if (!foundVowel)
                {
                    return (word + "ay");
                }
            }
        }
    }
}
