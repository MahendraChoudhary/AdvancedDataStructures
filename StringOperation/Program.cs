/*************************************************************************************
About: This program is written as part of the fulfilment for the ‘put your Unitname’
Course - HND in Computing at Icon College, London.
Date : Put date here
By : Put your name here. Student ID: Put your student ID Here
*************************************************************************************/

using System;

namespace StringOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = null;
            StringUtility utility = new StringUtility();
            Console.WriteLine("\tplease enter input string.");
            string input = Console.ReadLine();


            do
            {
                
                Console.WriteLine("\tPlease select your choice and enter values 1-5." +
                    " \n\n\t1) Get a character position from string." +
                    " \n\n\t2) Extract a number from string." +
                    " \n\n\t3) Order string alphabetically." +
                    " \n\n\t4) Remove spaces from string." +
                    " \n\n\t5) Convert string to pig latin.\n\n");
                int caseSwitch = GetChoice();
                if (caseSwitch < 0 && caseSwitch > 5)
                {
                    Console.WriteLine("Please enter only int values, enter number 1-5");
                    continue;
                }

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("\tPlease enter character to find:");
                        string chars = Console.ReadLine();
                        if (chars.Length != 1)
                        {
                            Console.WriteLine("\tGiven input isn't valid character.");
                            break;
                        }

                        int pos = utility.GetCharPosition(input, chars[0]);
                        Console.WriteLine($"\tCharacter {chars[0]} found at position {pos}.");
                        break;
                    case 2:
                        Console.WriteLine("\tPlease enter number to extract:");
                        int number = 0;
                        if (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.WriteLine("\tGiven input is not a valid number.");
                            break;
                        }

                        Console.WriteLine($"\tString after extracting number {number} : " + utility.ExtractNumber(input, number));
                        break;
                    case 3:
                        Console.WriteLine("\tString after ordering alphabetically: " + utility.OrderAlphabetical(input));
                        break;
                    case 4:
                        Console.WriteLine("\tString after removing spaces: " + utility.RemoveSpaces(input));
                        break;
                    case 5:
                        Console.WriteLine("\tPig latin of string: "+utility.MakePigLatin(input));
                        break;
                    default:
                        Console.WriteLine("Please enter only int values, enter number 1-5");
                        break;
                }

                Console.WriteLine("Please press 'Y' to perform more actions else press any other key.");
                answer = Console.ReadLine().ToUpper();
            } while (answer == "Y");
        }

        private static int GetChoice()
        {
            int choices = 0;
            int.TryParse(Console.ReadLine(), out choices);
            return choices;
        }
    }
}
