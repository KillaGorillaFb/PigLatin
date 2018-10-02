using System;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       10/2/2018
/// Purpose:    Pig Latin Project
/// </summary>
namespace PigLatin
{
    class PigLatin
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence to convert to PigLatin:");
            string sentence = Console.ReadLine();
            var pigLatin = GetSentenceInPigLatin(sentence);
            Console.WriteLine(pigLatin);
            Console.ReadLine();
        }//end of private static void Main(string[] args)

        private static object GetSentenceInPigLatin(string sentence)
        {
            const string vowels = "AEIOUYaeiouy";
            var returnSentence = "";
            foreach (var word in sentence.Split())//.split here splits my string
            {
                var firstLetter = word.Substring(0, 1);
                var restOfWord = word.Substring(1, word.Length - 1);
                var currentLetter = vowels.IndexOf(firstLetter, StringComparison.Ordinal);

                if (currentLetter == -1)
                {
                    returnSentence += restOfWord + firstLetter + "ay ";
                }//end of if
                else
                {
                    returnSentence += word + "way ";
                }//end of else
            }//end of foreach (var word in sentence.Split())
            return returnSentence;
        }//end of private static object GetSentenceInPigLatin(string sentence)
    }//end of class PigLatin
}//end of namespace PigLatin
