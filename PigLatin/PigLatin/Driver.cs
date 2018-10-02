using System;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       10/2/2018
/// Purpose:    Pig Latin Project
/// </summary>

namespace PigLatin
{
    class Driver
    {
        public static string GetSentenceInPigLatin(string sentence)
        {
            const string vowels = "AEIOUYaeiouy";
            var returnSentence = "";
            foreach (var word in sentence.Split())
            {
                var firstLetter = word.Substring(0, 1);
                var restOfWord = word.Substring(1, word.Length - 1);
                var currentLetter = vowels.IndexOf(firstLetter, StringComparison.Ordinal);

                if (currentLetter == -1)
                {
                    returnSentence += restOfWord + firstLetter + "ay ";
                }
                else
                {
                    returnSentence += word + "way ";
                }
            }
            return returnSentence;
        }
    }
}
