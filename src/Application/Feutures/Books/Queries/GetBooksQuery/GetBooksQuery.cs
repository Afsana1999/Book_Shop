using BookShop.Application.Common.Exceptioons;
using BookShop.Application.Feutures.Books.Dtos;

namespace BookShop.Application.Feutures.Books.Queries.GetBooksQuery
{
    public record GetBooksQuery : IRequest<IEnumerable<BookDetailDto>>;
    public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, IEnumerable<BookDetailDto>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBooksQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookDetailDto>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            var books =await _bookRepository.GetAllAsync(orderBy: o => o.CategoryId, tracking: false, lazyLoading: true, cancellationToken: cancellationToken, includes: Includes.Bookincludes);
            if (books==null)
            {
                throw new NotFoundException("Books was not found");
            }
            var result=_mapper.Map<IEnumerable<BookDetailDto>>(books);
            return result;
        }
    }
}
