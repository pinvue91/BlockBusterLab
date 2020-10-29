using System;
using System.Collections.Generic;

namespace BlockBusterLab
{
    abstract class Movie
    {

        //properties
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        //constructors
        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;

        }

        //methods
          
        //prints scenes from movie
        public void PrintScenes()
        { 
            for(int i = 0; i<Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine(scene);

            }
        }

        //allows for child class to play scenes
        public virtual void Play() { }

        //display movie information
        public void ShowMovieInfo()
        {
            Console.WriteLine($"Title: {Title}\nGenre: {Category}\nRuntime: {RunTime}");
        }


    }
}
