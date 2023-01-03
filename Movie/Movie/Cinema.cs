using System;
using System.Collections.Generic;
using System.Linq;


namespace Movie
{
    internal class Cinema
    {
        public List<Movie> Movies { get; set; }

        public List<Movie> Hall1 { get; set; }
        public List<Movie> Hall2 { get; set; }


        public Cinema()
        {
            Hall1 = new List<Movie>();
            Hall2 = new List<Movie>();
            Movies = new List<Movie>();
        }
        public void DisplayMovie(Movie movie)
        {
            Console.WriteLine($"*Name: {movie.Title}");
            Console.WriteLine($"*Language: { movie.Language}");
            Console.WriteLine($"*Genre: {movie.Genre}");
            Console.WriteLine($"*Date time: {movie.Datetime}");
            Console.WriteLine("********************************");
        }
        public List<Movie> SearchMovieByName(string name)
        {
            List<Movie> result = Movies
              .Where(x => x.Title.Contains(name))
              .ToList();
            return result;
        }
        public List<Movie> SearchMovieByGenre(string genre)
        {
            List<Movie> result = Movies
              .Where(x => x.Genre.Contains(genre))
              .ToList();
            return result;
        }
        public List<Movie> SearchMovieByDate(string date)
        {
            List<Movie> result = Movies
             .Where(x => x.Datetime.Contains(date))
             .ToList();
            return result;
        }
        public Movie SearchMovieInHall1(string name)
        {
            var result = Hall1.FirstOrDefault(x => x.Title == name);
            return result;
        }
        public Movie SearchMovieInHall2(string name)
        {
            var result = Hall2.FirstOrDefault(x => x.Title == name);
            return result;
        }

        public void DisplayMovies(List<Movie> movies)
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("NO RESULT!");
            }
            else
            {
                foreach (var item in movies)
                {
                    DisplayMovie(item);
                }
            }
        }
    }
}



