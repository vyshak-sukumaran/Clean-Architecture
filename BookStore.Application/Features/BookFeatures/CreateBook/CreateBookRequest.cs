using MediatR;

namespace BookStore.Application.Features.BookFeatures.CreateBook
{
    public sealed record CreateBookRequest(string Title, string Description, string Author) : IRequest<CreateBookResponse>;
}
