using BookShop.Application.Common.Constants;
using BookShop.Application.Feutures.Address.Commands.CreateAddressCommand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Feutures.Address.Validators.CreateAddressValidator
{
    public class CreateAddressCommandValidator:AbstractValidator<CreateAddressCommand>
    {
        public CreateAddressCommandValidator( )
        {
            RuleFor(a => a.AddressName)
                .NotEmpty().WithMessage(Messages.DoesnotEmptyMessage("AddresName"));
            RuleFor(a => a.ZIPCode).NotEmpty().WithMessage(Messages.DoesnotEmptyMessage("ZIPCode"));
            RuleFor(a => a.City).NotEmpty().WithMessage(Messages.DoesnotEmptyMessage("City"));

        }
       
    }
}
