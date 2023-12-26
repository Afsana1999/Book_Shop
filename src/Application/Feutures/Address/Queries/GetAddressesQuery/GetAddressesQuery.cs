
namespace BookShop.Application.Feutures.Address.Queries.GetAddressesQuery;

public record GetAddressesQuery:IRequest<IEnumerable<AddressDetailDto>>;
public class GetAddressesQueryHandler : IRequestHandler<GetAddressesQuery, IEnumerable<AddressDetailDto>>
{
    private readonly IAddressRepository _addressRepository;
    private readonly IMapper _mapper;

    public GetAddressesQueryHandler(IAddressRepository addressRepository, IMapper mapper)
    {
        _addressRepository = addressRepository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<AddressDetailDto>> Handle(GetAddressesQuery request, CancellationToken cancellationToken)
    {
        var entity = await _addressRepository.GetAllAsync(orderBy: x => x.CountryId, null, false, true, cancellationToken, Includes.AddressIncludes);
        CommonExceptionHelper.ListResponseNotFoundExceptionHelper(entity);
        IEnumerable<AddressDetailDto> result = _mapper.Map<IEnumerable<AddressDetailDto>>(entity);
        return result;
    }
}

