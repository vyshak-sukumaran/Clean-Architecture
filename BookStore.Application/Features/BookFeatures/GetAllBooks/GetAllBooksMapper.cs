
using AutoMapper;
using BookStore.Domain.Entities;

namespace BookStore.Application.Features.BookFeatures.GetAllBooks
{
    public sealed class GetAllBooksMapper : Profile
    {
        public GetAllBooksMapper() 
        {
            CreateMap<Book, GetAllBooksResponse>();
        }
    }
}
