using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Challenge02 Asking user to enter passcode

            // creating prompts
            string greeting = "Welcome to Challenge02!\n----------------------\n";
            string userNamePrompt = "Please enter your username:\n";
            string userPasscodePrompt = "Please enter your passcode:\n";
            string correctPasscodePrompt = "Passcode Authenticated.\n";
            string wrontPasscodePrompt = "Passcode Incorrect. Unauthenticated.\n";

            string[] prompts = {greeting, userNamePrompt, userPasscodePrompt};
            string[] passcodeAnswers = {correctPasscodePrompt, wrontPasscodePrompt};

            // variables to store data
            string correctPasscode = "secret";

            string userName = null;
            string userPasscode = null;
            bool correctCode = false;

            // Begining program

            Console.WriteLine(prompts[0]);
            Console.WriteLine(prompts[1]);
            userName= Console.ReadLine();

            while (correctCode != true)
            {
                Console.WriteLine(prompts[2]);
                userPasscode = Console.ReadLine();

                // passcode logic
                if (userPasscode != correctPasscode)
                {
                    Console.WriteLine(passcodeAnswers[1]);
                }
                else
                {
                    correctCode= true;
                }
            }
            Console.WriteLine(passcodeAnswers[0]); 
        }
    }
}
