namespace Book.Management.Domain.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string author, string isbn, DateTime publishedYear)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            PublishedYear = publishedYear;

            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.MinValue;
            Active = true;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime PublishedYear { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Active { get; set; }

        public DateTime CreatedAt { get; private set; }
        public List<Loan> Loans { get; private set; }

    }
}
