namespace BookManager
{
    public static class BookExtensions
    {
        public static Book WrittenBy(this Book book, string author)
        {
            book.Author = author;

            return book;
        }

        public static Book PublishedIn(this Book book, int year)
        {
            book.PublishedYear = year;

            return book;
        }

        public static Book InGenre(this Book book, Genre genre)
        {
            book.Genre = genre;

            return book;
        }
    }
}
