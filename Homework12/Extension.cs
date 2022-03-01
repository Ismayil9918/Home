using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    static class Extension
    {
        public static string isCapitalized(this string word)
        {
            word = word.ToLower();


            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(char.ToUpper(word[0]).ToString());

            for (int i = 1; i < word.Length; i++)
            {
                stringBuilder.Append(word[i]);
            }

            return stringBuilder.ToString();

        }
    }
}
