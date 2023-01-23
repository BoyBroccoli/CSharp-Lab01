namespace Challenge5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Welcome to Challenge One Questionaire!\n";
            string askName = "What is your name?\n";
            string askAge = "What is your age?\n";
            string askMonth = "What month were you born in (as a number)?\n";
            string askDay = "What day were you born?\n";
            string askColor = "What is your favorite color?\n";
            string askCartoon = "What is your favorite cartoon growing up?\n";

            // stoirg prompts in an array
            string[] questions = { greeting, askName, askAge, askMonth, askDay ,askColor, askCartoon };

            // will store data in these variables
            string userName = "";
            string userAge = "";
            int userMonth = 0;
            int userDay = 0;
            string userColor = "";
            string userCartoon = "";
            string zodiacSign;

            Console.WriteLine(questions[0]);
            Console.WriteLine(questions[1]);
            userName = TryAgain();

            Console.WriteLine(questions[2]);
            userAge = TryAgain();
            

            Console.WriteLine(questions[3]);
            userMonth = int.Parse(TryAgain());

            Console.WriteLine(questions[4]);
            userDay = int.Parse(TryAgain());

            zodiacSign = GetZodiacSign(userMonth, userDay);
            

            Console.WriteLine(questions[5]);
            userColor = TryAgain();
            

            Console.WriteLine(questions[6]);
            userCartoon = TryAgain();
            

            string[] answers = { userName, userAge, userColor, userCartoon };

            Console.WriteLine("\nSURVERY ANSWERS\n --------------------------------------------");

            Console.WriteLine($"Your name is: {answers[0]}");
            Console.WriteLine($"{answers[0]} you are: {answers[1]} years old.");
            Console.WriteLine($"{answers[0]} your zodiac sign is: {zodiacSign}");
            Console.WriteLine($"{answers[0]} your favorite color is: {answers[2]}");
            Console.WriteLine($"{answers[0]} your favorite cartoon growing up was: {answers[3]}");
        }

        static string TryAgain()
        {

            string input = Console.ReadLine();
            if (input == "" || input == null)
            {
                Console.WriteLine("You didn't type anything. Please try again.");
                return Console.ReadLine();
            }

            return input;
            
        }

        // Function that takes in a int month and int day to determin zodiac sign using a switch statement
        static string GetZodiacSign(int month, int day)
        {
                       
            switch(month)
            {
                case 1:
                    if(day < 20)
                    {
                        return "Capricorn";
                    }
                    else
                    {
                        return "Aquarius";
                    }
                case 2:
                    if (day < 19)
                    {
                        return "Aquarius";
                    }
                    else
                    {
                        return "Pisces";
                    }
                case 3:
                    if (day < 21)
                    {
                        return "Pisces";
                    }
                    else
                    {
                        return "Aries";
                    }
                case 4:
                    if (day < 20)
                    {
                        return "Aries";
                    }
                    else
                    {
                        return "Taurus";
                    }
                case 5:
                    if (day < 21)
                    {
                        return "Taurus";
                    }
                    else
                    {
                        return "Gemini";
                    }
                case 6:
                    if (day < 21)
                    {
                        return "Gemini";
                    }
                    else
                    {
                        return "Cancer";
                    }
                case 7:
                    if (day < 23)
                    {
                        return "Cancer";
                    }
                    else
                    {
                        return "Leo";
                    }
                case 8:
                    if (day < 23)
                    {
                        return "Leo";
                    }
                    else 
                    {
                        return "Virgo";
                    }
                case 9:
                    if (day < 23)
                    {
                        return "Virgo";
                    }
                    else
                    {
                        return "Libra";
                    }
                case 10:
                    if (day < 23)
                    {
                        return "Libra";
                    }
                    else
                    {
                        return "Scorpio";
                    }
                case 11:
                    if (day < 22)
                    {
                        return "Scorpio";
                    }
                    else
                    {
                        return "Sagittarius";
                    }
                case 12:
                    if (day < 22)
                    {
                        return "Sagittarius";
                    }
                    else
                    {
                        return "Capricorn";
                    }
                default:
                    return "Invalid input. Please enter a valid birth month and day.";
            }
        }

    }
}