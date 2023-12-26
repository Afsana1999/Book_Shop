using BookShop.Application.Common.Exceptioons;

namespace BookShop.Application.Feutures.Books.Commands.DeleteBookCommand;

public record DeleteBookCommand(int id) : IRequest;
public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
{
    private readonly IBookRepository _bookRepository;

    public DeleteBookCommandHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        var entity = await _bookRepository.GetAsync(x => x.Id == request.id, false, false, cancellationToken);
        if (entity == null)
            throw new NotFoundException(nameof(DeleteBookCommand), request.id);

        await _bookRepository.DeleteAsync(entity, cancellationToken);
        await _bookRepository.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }

}