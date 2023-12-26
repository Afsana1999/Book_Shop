using BookShop.Application.Common.Exceptioons;
using BookShop.Application.Common.Helper.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Feutures.Address.Commands.DeleteAddressCommand
{
    public record DeleteAddressCommand(int id):IRequest;

    public class DeleteAddressCommandhandler : IRequestHandler<DeleteAddressCommand>
    {
        private readonly IAddressRepository _addressRepository;

        public DeleteAddressCommandhandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<Unit> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            var entity =await _addressRepository.GetAsync(a => a.Id == request.id, false, false, cancellationToken);
            CommonExceptionHelper.ResponseNotFoundExceptionHelper(entity);

            await _addressRepository.DeleteAsync(entity,cancellationToken);
            await _addressRepository.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
