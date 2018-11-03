using System;
using System.Linq;
using System.Text;

namespace StringOperation
{
    internal class StringUtility
    {

        /*************************************************************************************
        About: This method takes string as input and return PigLatin of string.
        *************************************************************************************/
        public string MakePigLatin(string input)
        {
            string[] words = input.Split(' ');
            input = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= 1)
                    continue;

                string output = new String(words[i].ToCharArray());
                output = output.Substring(1, output.Length - 1) + output.Substring(0, 1) + "ay";
                if (input != string.Empty)
                    input += " " + output;
                else
                    input += output;
            }

            return input;
        }

        /*************************************************************************************
        About: This program takes string as input and returns string alphabetical order.
        *************************************************************************************/
        public string OrderAlphabetical(string input)
        {
            return String.Concat(input.OrderBy(c => c));
        }

        /*************************************************************************************
        About: This program takes string as input and return string without any space.
        *************************************************************************************/
        public string RemoveSpaces(string input)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                    temp.Append(input[i]);
            }

            return temp.ToString();
        }

        /*************************************************************************************
        About: This program takes string as input and finds a number and removes from string.
        *************************************************************************************/
        public string ExtractNumber(string input, int number)
        {
            if (input.Contains(number.ToString()))
            {
                input = input.Replace(number.ToString(), "");
            }

            return input;
        }

        /*************************************************************************************
        About: This program takes string as input and return position of a char.
        *************************************************************************************/
        public int GetCharPosition(string input, char ch)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ch)
                    return i;
            }

            return -1;
        }
    }
}
