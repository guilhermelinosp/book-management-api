namespace Book.Management.Application.ViewModels.Book
{
    public class BookViewModel
    {
        public BookViewModel(int id, string title, string author, string isbn, DateTime publishedYear, DateTime createdAt)
        {
            Id = id;
            Title = title;
            Author = author;
            Isbn = isbn;
            PublishedYear = publishedYear;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Isbn { get; private set; }
        public DateTime PublishedYear { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
