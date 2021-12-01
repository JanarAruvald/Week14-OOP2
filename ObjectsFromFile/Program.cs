using System;
using System.IO;

namespace ObjectsFromFile
{
    class Program
    {
        class Movie
        {
            public string title;
            public string rating;
            public string year;


            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                year = _year;
                rating = _rating;

            }


        }
        static void Main(string[] args)
        {
            foreach(string movie in GetDataFromFile())
            {
                string[] tempArray = movie.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);
                Console.WriteLine($"Title: {newMovie.title}, Rating: {newMovie.rating}, Year: {newMovie.year}");
            }

            
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\opilane\samples\movies.txt";
            string[] datafromfile = File.ReadAllLines(filePath);
            return datafromfile;
        }
        public static void DisplayArrayElements(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine(element);
            }
        }

    }
}
