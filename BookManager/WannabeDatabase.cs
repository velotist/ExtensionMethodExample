using System.Collections.Generic;

namespace BookManager
{
    public class WannabeDatabase
    {
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<Genre> Genres { get; set; } = new List<Genre>();

        public static void AddBookToDatabase(Book book) => Books.Add(book);
        public static void AddGenreToDatabase(Genre genre) => Genres.Add(genre);
    }
}
