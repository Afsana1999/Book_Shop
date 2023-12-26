namespace BookShop.Application.Feutures.Books.Commands.CreateBookCommand;

public class CreateBookCommand : IRequest<int>, IMapFrom<Book>
{
    public string BookName { get; set; } = null!;
    public string? Description { get; set; }
    public double DiscountPercent { get; set; }
    public int Quantity { get; set; }

    //One to Many
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public int TopicId { get; set; }
    public Topic Topic { get; set; }
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }

    //One to Many <->
    public virtual ICollection<BookImage> BookImages { get; set; }
    public virtual ICollection<Price> Prices { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }
    public virtual ICollection<WishList> WishLists { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }
}
public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public CreateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        Book entity = _mapper.Map<Book>(request);
        Book result = await _bookRepository.AddAsync(entity, cancellationToken);
        await _bookRepository.SaveChangesAsync(cancellationToken);
        return result.Id;
    }
}
