using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_to_Number_Converter
{
    public class ConvertLetters
    {
        public int ConvertNumber(string word)
        {
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            char[] charWord = word.ToUpper().ToCharArray();

            int score = 0;

            for (int i = 0; i < word.Length; i++)
            {
                score += Array.IndexOf(letters, charWord[i]);
            }
            return score + word.Length;
        }
    }
}
