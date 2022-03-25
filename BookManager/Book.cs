using System.Collections.Generic;

namespace BookManager
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        public Genre Genre { get; set; }

        public static IEnumerable<Book> GetBooks()
        {
            return WannabeDatabase.Books;
        }

        public static IEnumerable<Genre> GetGenres()
        {
            return WannabeDatabase.Genres;
        }

        public static Book CreateBook(string title)
        {
            var book = new Book
            {
                Title = title
            };

            return book;
        }
    }
}
