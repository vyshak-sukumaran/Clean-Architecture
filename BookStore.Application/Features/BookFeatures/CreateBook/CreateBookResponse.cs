

namespace BookStore.Application.Features.BookFeatures.CreateBook
{
    public sealed record CreateBookResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
