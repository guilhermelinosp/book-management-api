namespace Book.Management.Domain.Entities
{
	public class Book(string title, string author, string isbn, DateTime publishedYear)
		: BaseEntity
	{
		public string Title { get; set; } = title;
		public string Author { get; set; } = author;
		public string Isbn { get; set; } = isbn;
		public DateTime PublishedYear { get; set; } = publishedYear;
		public DateTime UpdatedAt { get; set; } = DateTime.MinValue;
		public bool Active { get; set; } = true;

		public DateTime CreatedAt { get; private set; } = DateTime.Now;
		public List<Loan>? Loans { get; private set; }
	}
}