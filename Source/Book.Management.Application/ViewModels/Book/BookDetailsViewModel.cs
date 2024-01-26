namespace Book.Management.Application.ViewModels.Book
{
    public class BookDetailsViewModel(
        int id,
        string title,
        string author,
        string isbn,
        DateTime publishedYear,
        DateTime createdAt)
    {
        public int Id { get; private set; } = id;
        public string Title { get; private set; } = title;
        public string Author { get; private set; } = author;
        public string Isbn { get; private set; } = isbn;
        public DateTime PublishedYear { get; private set; } = publishedYear;
        public DateTime CreatedAt { get; private set; } = createdAt;
    }
}
