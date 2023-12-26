using BookShop.Domain.Entities.Auth;

namespace BookShop.Application.Feutures.Address.Commands.CreateAddressCommand;

public class CreateAddressCommand : IRequest<int>, IMapFrom<BSDE.Address>
{
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

    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, int>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            BSDE.Address entity = _mapper.Map<BSDE.Address>(request);
            BSDE.Address result = await _addressRepository.AddAsync(entity, cancellationToken);
            await _addressRepository.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
