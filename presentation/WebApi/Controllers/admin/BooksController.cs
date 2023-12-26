namespace BookShop.WebApi.Controllers.admin;


public class BooksController : BaseController
{
    [HttpGet("GetAllBooks")]
    public async Task<IActionResult> GetAllBook()
    {
        return Ok(await Mediator.Send(new GetBooksQuery()));
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromBody]GetBooksQuery getBooksQuery  )
    {
        return Ok(await Mediator.Send(getBooksQuery));
    }

    [HttpPost("AddBook")]
    public async Task<int> AddBook([FromBody] CreateBookCommand createBookCommand)
    {
        return await Mediator.Send(createBookCommand);
    }

    [HttpDelete]
    public async Task Delete([FromBody] DeleteBookCommand deleteBookCommand)
    {
        await Mediator.Send(deleteBookCommand);
    }

    [HttpPut]
    public async Task Update([FromBody] UpdateBookCommand updateBookCommand)
    {
        await Mediator.Send(updateBookCommand);
    }
}
