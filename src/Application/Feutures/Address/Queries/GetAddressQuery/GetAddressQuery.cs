using BookShop.Application.Feutures.Address.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Feutures.Address.Queries.GetAddressQuery
{
    public record GetAddressQuery(int id):IRequest<AddressDetailDto>;

    public class GetAddressQueryHandler : IRequestHandler<GetAddressQuery, AddressDetailDto>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetAddressQueryHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<AddressDetailDto> Handle(GetAddressQuery request, CancellationToken cancellationToken)
        {
            var entity = await _addressRepository.GetAsync(x => x.Id == request.id, false, true, cancellationToken, Includes.AddressIncludes);
            CommonExceptionHelper.ResponseNotFoundExceptionHelper(entity);

            AddressDetailDto dto = _mapper.Map<AddressDetailDto>(entity);
            return dto;

        }
    }
}
