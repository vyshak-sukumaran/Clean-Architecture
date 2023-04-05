using BookStore.Domain.Entities;

namespace BookStore.Application.Repositories
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        Task<Book> GetByTitle(string title, CancellationToken cancellation);
    }
}
