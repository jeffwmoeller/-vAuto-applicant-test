using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// PP 1.4: In the programming language of your choice, 
// write a program that parses a sentence and replaces each word with the following: 
// first letter, number of distinct characters between first and last character, and last letter.  
// For example, Smooth would become S3h.  
// Words are separated by spaces or non-alphabetic characters and 
// these separators should be maintained in their original form and location in the answer.

// " alphabetic character - the conventional characters of the alphabet used to represent speech"

// Some edge cases need to be considered.
//
// Words with only 1 letter have a first character that is also the last character.
// There are 0 distinct characters between the first and last characters.
// 1 letter words such as 'a' will be represented as 'a0a'.
//
// Words with 2 letters may have different first and last characters.
// There are 0 distinct characters between the first and last characters.
// 2 letter words such as 'be' will be represented as 'b0e'.
//
// Apostrophes (and possibly other) non-alphabetic characters that could be contained in a
// single word will be treated as seperators.
// "don't" will produce 'd1n't0t".
//
// Words should not contain mixed case, but if they do, they will be treated as distinct characters.
// "upperUPPER" will produce "u6R".

namespace NumeronymCreator
{
    static public class NumeronymHelper
    {
        static public String NumeronymizeSentence(String sentence)
        {
            StringBuilder output = new StringBuilder();

            NumeronymBuilder numeronym = new NumeronymBuilder();

            foreach (Char ch in sentence)
            {
                // If this in an alphabetic character ...
                //
                // Char.IsLetter() works in all UNICODE languages/character sets,
                // so I18N is supported.
                if (Char.IsLetter(ch))
                {
                    // Add this character to the word to be numeronymized.
                    numeronym.Append(ch);
                }
                else
                {
                    // If there is a word to be numeronymized ...
                    if (!numeronym.IsEmpty())
                    {
                        // numeronymize that word ...
                        output.Append(numeronym.ToString());

                        // and discard the numeronymized word.
                        numeronym.Clear();
                    }

                    // Copy the non-alphanumeric character.
                    //
                    // "separators should be maintained in their original form and location in the answer"
                    output.Append(ch);
                }
            }

            // If there is a word to be numeronymized, numeronymize that word.
            if (!numeronym.IsEmpty()) output.Append(numeronym.ToString());

            return output.ToString();
        }
    }
}
