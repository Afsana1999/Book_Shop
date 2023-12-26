using BookShop.Application.Common.Exceptioons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Feutures.Books.Commands.UpdateBookCommand
{
    public class UpdateBookCommand : IRequest,IMapFrom<Book>
    {
        public int Id { get; set; }
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
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public UpdateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var entity = await _bookRepository.GetAsync(x => x.Id == request.Id, lazyLoading: false, cancellationToken: cancellationToken);
            if (entity == null)
            {
                throw new NotFoundException(nameof(UpdateBookCommand), request.Id);
            }
            //entity.BookName = request.BookName;
            //entity.Description = request.Description;
            //entity.AuthorId = request.AuthorId;
            //entity.CategoryId = request.CategoryId;
            //entity.Quantity = request.Quantity;
            //entity.DiscountPercent = request.DiscountPercent;
            var book = _mapper.Map<Book>(request);
            await _bookRepository.UpdateAsync(book, cancellationToken);
            await _bookRepository.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
