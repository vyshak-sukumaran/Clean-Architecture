
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(DataContext context) : base(context) { }
        public Task<Book> GetByTitle(string title, CancellationToken cancellationToken)
        {
            return Context.Books.FirstOrDefaultAsync(x => x.Title == title, cancellationToken);
        }
    }
}
