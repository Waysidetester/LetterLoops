using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------- Init app ----------------------
            Console.WriteLine("Please input a string");
            
            // ------ Accept/ Set User Input -----------
            string userInput = Console.ReadLine();
            string finalOutput = "";

            // -------- Loop over user input -----------
            for (int i = 0; i < userInput.Length; i++)
            {
                // Allows the ToUpper() method. Code wouldn't allow it on char
                string charToString = Convert.ToString(userInput[i]);
                string upperString = charToString.ToUpper();

                // Adds upper case char to the final output
                finalOutput += upperString;

                // checks position to determine if additional lowercase chars need to be added
                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        finalOutput += userInput[i];
                    }
                }

                // adds "-" after each char except for final char in string
                if (i != (userInput.Length - 1))
                {
                    finalOutput += "-";
                }
            }

            // prints final output
            Console.WriteLine(finalOutput);
            Console.WriteLine("press ENTER to exit");
            Console.ReadLine();
        }
    }
}
