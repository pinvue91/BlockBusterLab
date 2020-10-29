using System;
using System.Collections.Generic;
using System.Threading;

namespace BlockBusterLab
{
    class DVD : Movie
    {

        //constructor
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }

        //methods
        public override void Play()
        {
            bool keepWatchingDVD = true;

            while (keepWatchingDVD)
            {
                Console.Clear();
                Console.WriteLine("What scene would you like to watch?");
                Console.WriteLine();


                for (int i = 0; i < Scenes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Scenes[i]}");
                }

                try
                {
                    int sceneChoice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(Scenes[sceneChoice - 1]);
                    Thread.Sleep(1000);
                }
                catch
                {
                    Console.WriteLine("That is not an option!");
                    
                }

                Console.WriteLine("Do you want to watch another scene? (y/n)");

                string continueYesNo = Console.ReadLine().Trim().ToLower();               

                if(continueYesNo =="y")
                { }
                else if(continueYesNo == "n")
                {
                    keepWatchingDVD = false;
                }
                else 
                {
                    Console.WriteLine("I don't understand! Let's go back to the scene selection.");
                    Thread.Sleep(1000);
                }

            }

        }


    }
}
