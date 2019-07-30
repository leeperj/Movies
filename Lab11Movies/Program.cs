using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Movies
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Movies> movies = new List<Movies>
            {
                new Movies("Pet Sematary", "horror"),
                new Movies("Nightmare on Elm Street", "horror"),
                new Movies("Friday the 13th","horror"),
                new Movies("A Night at the Roxbury", "comedy"),
                new Movies("Office Space", "comedy"),
                new Movies("Hangover","comedy"),
                new Movies("The Other Guys","comedy"),
                new Movies("The Lion King","animated"),
                new Movies("Up","animated"),
                new Movies("Moana","animated")
              
            };
            List<Movies> moviesAlphabetical = (movies.OrderBy(t => t.Title)).ToList();
            
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies on this list.");
            Console.WriteLine("======================================");
            bool goAgain = true;
            while (goAgain)
            { 
                Console.WriteLine("What category are you interested in?");
                Console.WriteLine("1. Horror.");
                Console.WriteLine("2. Comedy.");
                Console.WriteLine("3. Animated.");
                string userChoice = (Console.ReadLine().ToLower().Trim());

                foreach (var movie in moviesAlphabetical)
                {

                    if (userChoice == "horror" || userChoice == "1")
                    {
                        if (movie.Category == "horror")
                        {
                            Console.WriteLine(movie.Title);
                        }

                    }
                    else if (userChoice == "comedy" || userChoice == "2")
                    {
                        if (movie.Category == "comedy")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                    else if (userChoice == "animated" || userChoice == "3")
                    {
                        if (movie.Category == "animated")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input, please enter number or category.");
                        break;
                    }
                }

                string quitChoice;
                Console.WriteLine("Enter (Q)uit to exit, or any other key to run again");

                quitChoice = Console.ReadLine().Trim();

                if (quitChoice.ToLower() == "q" || quitChoice.ToLower() == "quit")
                {
                    goAgain = false;
                    
                }
            }
            

            
        }
    }
}
