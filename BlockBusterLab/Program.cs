using System;

namespace BlockBusterLab
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runProgram = true;
            BlockBuster bb = new BlockBuster();

            while (runProgram)
            {
                Console.Clear();
                Console.WriteLine("Welcome to GC Blockbuster!");
                Movie movieRental = bb.CheckOut();

                movieRental.ShowMovieInfo();

                Console.WriteLine();
                
                string playYesNo = GetUserInput("Play this movie? (y/n) ");

                if(playYesNo == "y")
                {
                    movieRental.Play();
                }

                else if(playYesNo == "n")
                {

                }

                else
                {
                    Console.WriteLine("Sorry, I don't understand!");
                }

                Console.Clear();
                string continueYesNo = GetUserInput("Would you like to continue renting? (y/n)");
                runProgram = ContinueProgram(continueYesNo);

            }

        }

        //get user input
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine().ToLower().Trim();
            return UserInput;
        }

        public static bool ContinueProgram(string yesNo)
        {
            while(yesNo != "y" && yesNo != "n")
            {
                Console.WriteLine("Invalid input!\nWould you like to continue renting? (y/n)");
                yesNo = Console.ReadLine().Trim().ToLower();
            }
            if(yesNo == "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Thank you. Come again!");
                return false;
            }
            
        }

    }
}
