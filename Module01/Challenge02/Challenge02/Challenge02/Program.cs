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
            string newPasscode = "";
            string userAnswer = "";
            bool correctCode = false;
            bool newCodeCorrect = false;

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

            Console.WriteLine("Would you like to change your passcode?\n Type 'y' for yes. \n Type 'n' for no.");
            userAnswer = Console.ReadLine().ToLower();

            if(userAnswer == "y")
            {
                Console.WriteLine("Please enter a new passcode:\n");
                newPasscode = Console.ReadLine();

                while(newCodeCorrect!= true)
                {
                    Console.WriteLine("Please Re-enter new passocde to confirm:\n");
                    var newPCode = Console.ReadLine();

                    if(newPCode == newPasscode)
                    {
                        newCodeCorrect = true;
                    }
                }

                Console.WriteLine("New passcode has been set!");
                
            }
            else
            {
                Console.WriteLine("A new passcode will not be set.\n Thank You.");
            }
            
        }
    }
}
