using System;
using System.Linq;

namespace CSAdvance.ExtensionMethod
{
    public static class StringExtension
    {
        public static string Shorten(this String inputString, int noOfWords)
        {
            if (noOfWords<0)
            {
                throw new ArgumentOutOfRangeException($"{noOfWords} cannot be 0 or less");
            }
            if (noOfWords == 0)
            {
                return "";
            }

            string[] words = inputString.Split(' ');

            if (words.Length <= noOfWords)
            {
                return inputString;
            }

            return string.Join(" ",words.Take(noOfWords))+"...";
        }
    }
}