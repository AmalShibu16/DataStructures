using DataStructures;

namespace datastructures
{
    internal class program
    {
        static void Main(string[] args)
        {
            Movie deadpool3;
            deadpool3.title = "deadpool & wolverine";
            deadpool3.releaseyear = 2024;
            deadpool3.price = 19.99;
            deadpool3.rating = MovieRating._15;

            Console.WriteLine(deadpool3.title + "(" + deadpool3.releaseyear + ") rated" + deadpool3.rating);

            Console.ReadKey();
            Console.WriteLine("\n\n");

            //Console.Clear();

            List<TVShow> shows = new List<TVShow>();
            shows.Add(new TVShow("The Lord of the Rings: The Rings of Power", 2022, 0, MovieRating._15));
            shows.Add(new TVShow("The Boys", 2019, 7.99, MovieRating._18));
            shows.Add(new TVShow("Ben and Holly's Little Kingdom", 2022, 0, MovieRating._U));

            for (int i = 0; i < shows.Count; i++)
            {
                Console.WriteLine(shows[i].ToString());
            }

            Console.ReadKey();
        }

        public enum MovieRating
        {
            _U,
            _12A,
            _12,
            _15,
            _18
        }

        public struct Movie
        {
            public string title;
            public int releaseyear;
            public double price;
            public MovieRating rating;
        }

    }



}