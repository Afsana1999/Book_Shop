using BookShop.Application.Common.Exceptioons;
using BookShop.Application.Feutures.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Feutures.Books.Queries.GetBookQuery
{
    public record GetBookQuery(int id):IRequest<BookDetailDto>;

    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, BookDetailDto>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBookQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookDetailDto> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var entity=await _bookRepository.GetAsync(x=>x.Id==request.id,false,true,cancellationToken, Includes.Bookincludes);
            if (entity==null)
            {
                throw new NotFoundException(nameof(BookDetailDto),request.id);
            }
            BookDetailDto result = _mapper.Map<BookDetailDto>(entity);
            return result;
        }
    }
}
