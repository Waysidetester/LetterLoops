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
                string charToString = Convert.ToString(userInput[i]);
                string upperString = charToString.ToUpper();
                finalOutput += upperString;
                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        finalOutput += userInput[i];
                    }
                }
                if (i != (userInput.Length - 1))
                {
                finalOutput += "-";
                }
                Console.WriteLine($"{userInput[i]} index is {i} and uppercase is {upperString}");
            }
            Console.WriteLine(finalOutput);
            Console.WriteLine("press ENTER to exit");
            Console.ReadLine();
        }
    }
}
