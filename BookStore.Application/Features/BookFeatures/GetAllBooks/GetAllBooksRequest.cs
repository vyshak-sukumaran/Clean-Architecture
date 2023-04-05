
using MediatR;

namespace BookStore.Application.Features.BookFeatures.GetAllBooks
{
    public sealed record GetAllBooksRequest : IRequest<List<GetAllBooksResponse>>;
}
