
using AutoMapper;
using BookStore.Application.Features.BookFeatures.CreateBook;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using MediatR;

namespace BookStore.Application.Features.BookFeatures.GetAllBooks
{
    public sealed class GetAllBooksHandler : IRequestHandler<GetAllBooksRequest, List<GetAllBooksResponse>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetAllBooksHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllBooksResponse>> Handle(GetAllBooksRequest request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllBooksResponse>>(books);
        }
    }
}
