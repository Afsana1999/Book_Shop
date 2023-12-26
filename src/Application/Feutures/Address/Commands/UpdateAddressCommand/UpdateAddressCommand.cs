
namespace BookShop.Application.Feutures.Address.Commands.UpdateAddressCommand;

public class UpdateAddressCommand:IRequest,IMapFrom<BSDE.Address>
{
    public int Id { get; set; }
    public string? AddressName { get; set; }
    public string? Appartment { get; set; }
    public string? ZIPCode { get; set; }

    //One to Many
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public int StateId { get; set; }
    public State State { get; set; }
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
}
public class UpdateAddressCommandhandler : IRequestHandler<UpdateAddressCommand>
{
    private readonly IAddressRepository _addressRepository;
    private readonly IMapper _mapper;

    public UpdateAddressCommandhandler(IAddressRepository addressRepository, IMapper mapper)
    {
        _addressRepository = addressRepository;
        _mapper = mapper;
    }
    public async Task<Unit> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
    {
        var entity = await _addressRepository.GetAsync(x => x.Id == request.Id, true, false, cancellationToken);
        CommonExceptionHelper.ResponseNotFoundExceptionHelper(entity);

        var address = _mapper.Map<BSDE.Address>(request);
        await _addressRepository.UpdateAsync(address, cancellationToken);
        await _addressRepository.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
