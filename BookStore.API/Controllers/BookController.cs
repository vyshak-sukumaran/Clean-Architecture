using BookStore.Application.Features.BookFeatures.CreateBook;
using BookStore.Application.Features.BookFeatures.GetAllBooks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [SwaggerOperation(Summary = "Get all Books.", Description = "This will get all books.")]
        [HttpGet]
        public async Task<ActionResult<List<GetAllBooksResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllBooksRequest(), cancellationToken);
            return Ok(response);
        }

        [SwaggerOperation(Summary = "Add new Book.", Description = "Adds new book.")]
        [HttpPost]
        public async Task<ActionResult<List<CreateBookResponse>>> Create(CreateBookRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
