using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Static_Extensions_Nullable_Enum.Extensions
{
    static class Extension
    {
        public static int Add(this int num,int num2)
        {
            return num + num2;
        }

        public static string Add(this string word, string word2)
        {
            return word + " " + word2;
        }


        public static bool isCapitalized(this string word)
        {
            if (char.IsUpper(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (!char.IsLower(word[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static bool customContains(this string word,char letter)
        {
            foreach (char let in word)
            {
                if(let == letter)
                {
                    return true;
                }
            }
            return false;
        }

        //public static bool customContains(this string word,string substring)
        //{

        //}


    }
}
