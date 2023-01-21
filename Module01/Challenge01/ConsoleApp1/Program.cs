using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Challenge One Multiple Choice Questions
            // Prompts
            string greeting = "Welcome to Challenge One Questionaire!\n";
            string askName = "What is your name?\n";
            string askAge = "What is your age?\n";
            string askMonth = "What month were you born in?\n";
            string askColor = "What is your favorite color?\n";
            string askCartoon = "What is your favorite cartoon growing up?\n";

            // stoirg prompts in an array
            string[] questions = {greeting, askName, askAge, askMonth, askColor, askCartoon};

            // will store data in these variables
            string userName = null;
            string userAge = null;
            string userMonth = null;
            string userColor = null;
            string userCartoon = null;

            Console.WriteLine(questions[0]);
            Console.WriteLine(questions[1]);
            userName= Console.ReadLine();

            Console.WriteLine(questions[2]);
            userAge= Console.ReadLine();

            Console.WriteLine(questions[3]);
            userMonth= Console.ReadLine();

            Console.WriteLine(questions[4]);
            userColor= Console.ReadLine();

            Console.WriteLine(questions[5]);
            userCartoon= Console.ReadLine();

            string[] answers = {userName, userAge, userMonth, userColor,userCartoon};

            Console.WriteLine("\nSURVERY ANSWERS\n --------------------------------------------");

            Console.WriteLine($"Your name is: {answers[0]}");
            Console.WriteLine($"{answers[0]} you are: {answers[1]} years old.");
            Console.WriteLine($"{answers[0]} you were born in the month of: {answers[2]}");
            Console.WriteLine($"{answers[0]} your favorite color is: {answers[3]}");
            Console.WriteLine($"{answers[0]} your favorite cartoon growing up was: {answers[4]}");
        }
    }
}
