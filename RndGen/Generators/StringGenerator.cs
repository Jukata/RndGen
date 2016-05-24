using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RndGen.Generators
{
    public static class StringGenerator
    {
        private static char[] letters = new char[]
        {
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z'
        };
        
        // Text generator
        public static string TextGenerator(int numberOfWords, int wordLowerLimit = 2, int wordUpperLimit = 10)
        {
            string[] wordsContainer = new string[numberOfWords];
            Random rnd = new Random();
            
            for (int i = 0; i < wordsContainer.Length; i++)
            {
                int wordLength = rnd.Next(wordLowerLimit, wordUpperLimit);
                string word = "";
                for (int j = 0; j < wordLength; j++)
                {
                    char randomChar = letters[rnd.Next(letters.Length)];
                    word += randomChar.ToString();
                }

                wordsContainer[i] = word;
            }

            return string.Join(" ", wordsContainer);
        }

        //  Single Word Generator
        public static string WordGenerator (int wordLowerLimit = 2, int wordUpperLimit = 10)
        {
            string word = "";
            Random rnd = new Random();
            int wordLength = rnd.Next(wordLowerLimit, wordUpperLimit);
            for (int i = 0; i < wordLength; i++)
            {
                char randomChar = letters[rnd.Next(letters.Length)];
                word += randomChar.ToString();
            }

            return word;
        }
    }
}
