using System;
using System.Linq;

namespace BookManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            WannabeDatabase.AddGenreToDatabase(new Genre { Name = "True Crime" });
            WannabeDatabase.AddGenreToDatabase(new Genre { Name = "Science Fiction" });

            var genres = Book.GetGenres();

            var book1 = Book.CreateBook("Own Book")
                            .WrittenBy("Me Myself And I")
                            .PublishedIn(2022)
                            .InGenre(genres.ElementAt(0));

            var book2 = Book.CreateBook("Your Book")
                            .WrittenBy("Holy Ghost")
                            .PublishedIn(2019)
                            .InGenre(genres.ElementAt(1));

            WannabeDatabase.AddBookToDatabase(book1);
            WannabeDatabase.AddBookToDatabase(book2);

            var books = Book.GetBooks();

            string message = string.Format("{0,-20} {1,-20} {2,-20} {3,-20}\n\n",
                "Title", "Author", "Published Year", "Genre");

            for (var index = 0; index < books.Count(); index++)
            {
                message += string.Format("{0,-20} {1,-20} {2,-20} {3,-20}\n",
                    books.ElementAt(index).Title,
                    books.ElementAt(index).Author,
                    books.ElementAt(index).PublishedYear,
                    books.ElementAt(index).Genre.Name);
            }

            Console.WriteLine($"{message}");

            Console.WriteLine($"Press key...");
            Console.ReadKey();
        }
    }
}
