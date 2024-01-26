namespace Book.Management.Domain.Repositories
{
    public interface IBookRepository
    {
        public Task<List<Entities.Book>> GetAllBooksAsync();
        public Task<Entities.Book> GetBookByIdAsync(int id);
        public Task AddBookAsync(Entities.Book book);
        public Task SaveChangesAsync();
    }
}
