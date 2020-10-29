using System;
using System.Collections.Generic;
using System.Threading;

namespace BlockBusterLab
{
    class VHS : Movie
    {
        //VHS Property
        public int CurrentTime { get; set; } = 0; //<<-- you can give properties an initial value here if you ever want to


        //constructor
        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {
            
        }

        //method override
        public override void Play()
        {
            Console.Clear();
            Console.WriteLine("Now playing");
            while(CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine($"{CurrentTime+1}  : {scene}");
                Thread.Sleep(1500);
                CurrentTime++;
            }
                        
            Console.WriteLine("You need to rewind the movie, its over!");
            Thread.Sleep(1500);

            Console.WriteLine("Would you like to rewind? (y/n)");
            string rewindYesNo = Console.ReadLine().Trim().ToLower();
            if(rewindYesNo == "y")
            {
                Rewind();
                Console.WriteLine("Now rewinding...this may take a minute...");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("I guess you don't want to be kind and rewind. Whatever...");
                Thread.Sleep(1500);
            }

            
        }

        //regular methods
        public void Rewind()
        {
            CurrentTime = 0;
        }



    }
}
