using System;
using System.Collections.Generic;

namespace BlockBusterLab
{
    class BlockBuster
    {
        //BlockBuster property
        public List<Movie> Movies { get; set; } = new List<Movie>();

        //constructor
        public BlockBuster()
        {
            List<string> scenes1 = new List<string>();
            scenes1.Add("I'm the king of the world!");
            scenes1.Add("Romance stuff");
            scenes1.Add("Ship sinks.");
            VHS v1 = new VHS("Titanic", Genre.Romance, 194, scenes1);


            List<string> scenes2 = new List<string>();
            scenes2.Add("Orge stuff.");
            scenes2.Add("Dragon chase scene.");
            scenes2.Add("Donkey talks alot.");
            VHS v2 = new VHS("Shrek", Genre.Comedy, 186, scenes2);


            List<string> scenes3 = new List<string>();
            scenes3.Add("Singing about stuff");
            scenes3.Add("Singing about love");
            scenes3.Add("Donkey sings a lot");
            VHS v3 = new VHS("Shrek the Musical", Genre.Comedy, 999, scenes3);

            List<string> scenes4 = new List<string>();
            scenes4.Add("Stanley Yelnats is sent to a camp to dig holes for steal shoes.");
            scenes4.Add("Stanley meets Zero and escapes camp.");
            scenes4.Add("Stanley and Zero find God's thumb and reverse family curse.");
            DVD D1 = new DVD("Holes", Genre.Drama, 130, scenes4);

            List<string> scenes5 = new List<string>();
            scenes5.Add("Jackie Chan and Chris Tucker team up to find a missing kid.");
            scenes5.Add("Lots of fighting.");
            scenes5.Add("Beats up mafia boss and saves kid.");
            DVD D2 = new DVD("Rush Hour", Genre.Action, 145, scenes5);

            List<string> scenes6 = new List<string>();
            scenes6.Add("Little kid gets lured into sewer and is eaten by a clown.");
            scenes6.Add("Curious group of kids explore haunted house and discover evil clown.");
            scenes6.Add("Curious group of kids out smart and kill evil clown...for now.");
            DVD D3 = new DVD("IT", Genre.Horror, 165, scenes6);

            Movies.Add(v1);
            Movies.Add(v2);
            Movies.Add(v3);
            Movies.Add(D1);
            Movies.Add(D2);
            Movies.Add(D3);

        }

        //methods
        public void PrintMovieTitles()
        {
            for(int i =0; i<Movies.Count;i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"{i+1}. {m.Title}");
            }
        }

        public Movie CheckOut()
        {
            Console.WriteLine("Please select a movie from the list to check out (enter 1 - 6): ");
            PrintMovieTitles();
                 
            Console.WriteLine();

            int movieIndex;

            while (!int.TryParse(Console.ReadLine(), out movieIndex) || movieIndex < 1 || movieIndex > Movies.Count)
            {
                Console.Clear();
                Console.WriteLine("Not a valid input!\nPlease select a movie from the list (enter 1-6): ");
                PrintMovieTitles();
            }
                        
            Movie output = Movies[movieIndex-1]; 

            return output;

        }

            
        

    }
}
