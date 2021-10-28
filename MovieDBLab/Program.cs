using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieDBLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LET'S GOOOOOOOOOOO");

            //CreateDB();

            //foreach(Movie m in SearchByGenre("Scifi"))
            //{
            //    Console.WriteLine(m.Title);
            //}

            Console.WriteLine("Welcome to Radeen's Screens. Search by either title or genre. title/genre");
            string choice = Console.ReadLine();

            List<Movie> result = new List<Movie>();
            if(choice.ToLower() == "genre")
            {
                Console.WriteLine("Please type in a genre");
                string genre = Console.ReadLine();
                result = searchByGenre(genre);
            }
            else if(choice.ToLower() == "title")
            {
                Console.WriteLine("Please type in a title");
                string title = Console.ReadLine();
                result = searchByTitle(title);
            }

            foreach(Movie m in result)
            {
                Console.WriteLine($"{m.Title} | {m.Genre} | {m.Runtime} hours ");
            }
            
        }

        static List<Movie> searchByGenre (string genre)
        {
            using(MovieDBContext context = new MovieDBContext())
            {
                return context.Movies.Where(m => m.Genre.ToLower() == genre.ToLower()).ToList();
            }
        }

        static List<Movie> searchByTitle(string title)
        {
            using (MovieDBContext context = new MovieDBContext())
            {
                return context.Movies.Where(m => m.Title.ToLower() == title.ToLower()).ToList();
            }
        }

        //method to create DB
        static void CreateDB()
        {
            using (MovieDBContext context = new MovieDBContext())
            {
                Movie m1 = new Movie
                {
                    Title = "Parasite",
                    Genre = "Drama",
                    Runtime = 2.25
                };
                Movie m2 = new Movie
                {
                    Title = "Eighth Grade",
                    Genre = "Drama",
                    Runtime = 1.50
                };
                Movie m3 = new Movie
                {
                    Title = "Ford v Ferrari",
                    Genre = "Drama",
                    Runtime = 2.50
                };
                Movie m4 = new Movie
                {
                    Title = "Inglourioous Basterds",
                    Genre = "Drama",
                    Runtime = 2.50
                };
                Movie m5 = new Movie
                {
                    Title = "Moneyball",
                    Genre = "Drama",
                    Runtime = 2.25
                };
                Movie m6 = new Movie
                {
                    Title = "Borat",
                    Genre = "Comedy",
                    Runtime = 1.50
                };
                Movie m7 = new Movie
                {
                    Title = "Knives Out",
                    Genre = "Comedy",
                    Runtime = 2.25
                };
                Movie m8 = new Movie
                {
                    Title = "The Hangover",
                    Genre = "Comedy",
                    Runtime = 1.50
                };
                Movie m9 = new Movie
                {
                    Title = "The Other Guys",
                    Genre = "Comedy",
                    Runtime = 2.00
                };
                Movie m10 = new Movie
                {
                    Title = "Friday",
                    Genre = "Comedy",
                    Runtime = 1.50
                };
                Movie m11 = new Movie
                {
                    Title = "Howl's Moving Castle",
                    Genre = "Animated",
                    Runtime = 2.00
                };
                Movie m12 = new Movie
                {
                    Title = "Spider-Man: Into the Spider-Verse",
                    Genre = "Animated",
                    Runtime = 2.00
                };
                Movie m13 = new Movie
                {
                    Title = "Demon Slayer: Mugen Train",
                    Genre = "Animated",
                    Runtime = 2.00
                };
                Movie m14 = new Movie
                {
                    Title = "Klaus",
                    Genre = "Animated",
                    Runtime = 1.50
                };
                Movie m15 = new Movie
                {
                    Title = "Your Name",
                    Genre = "Animated",
                    Runtime = 1.75
                };
                Movie m16 = new Movie
                {
                    Title = "How to Train Your Dragon",
                    Genre = "Animated",
                    Runtime = 1.75
                };
                Movie m17 = new Movie
                {
                    Title = "District 9",
                    Genre = "SciFi",
                    Runtime = 2.00
                };
                Movie m18 = new Movie
                {
                    Title = "Arrival",
                    Genre = "SciFi",
                    Runtime = 2.00
                };
                Movie m19 = new Movie
                {
                    Title = "Dune",
                    Genre = "SciFi",
                    Runtime = 2.50
                };
                Movie m20 = new Movie
                {
                    Title = "The Martian",
                    Genre = "SciFi",
                    Runtime = 2.50
                };
                Movie m21 = new Movie
                {
                    Title = "Blade Runner",
                    Genre = "SciFi",
                    Runtime = 2.00
                };

                context.Movies.Add(m1);
                context.Movies.Add(m2);
                context.Movies.Add(m3);
                context.Movies.Add(m4);
                context.Movies.Add(m5);
                context.Movies.Add(m6);
                context.Movies.Add(m7);
                context.Movies.Add(m8);
                context.Movies.Add(m9);
                context.Movies.Add(m10);
                context.Movies.Add(m11);
                context.Movies.Add(m12);
                context.Movies.Add(m13);
                context.Movies.Add(m14);
                context.Movies.Add(m15);
                context.Movies.Add(m16);
                context.Movies.Add(m17);
                context.Movies.Add(m18);
                context.Movies.Add(m19);
                context.Movies.Add(m20);
                context.Movies.Add(m21);

                context.SaveChanges();
            }
        }
    }
}
