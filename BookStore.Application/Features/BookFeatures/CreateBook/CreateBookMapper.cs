
using AutoMapper;
using BookStore.Domain.Entities;

namespace BookStore.Application.Features.BookFeatures.CreateBook
{
    public sealed class CreateBookMapper : Profile
    {
        public CreateBookMapper() 
        {
            CreateMap<CreateBookRequest, Book>();
            CreateMap<Book, CreateBookResponse>();
        }
    }
}
