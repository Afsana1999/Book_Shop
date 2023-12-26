using BookShop.Application.Feutures.Books.Commands.DeleteBookCommand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.Feutures.Books.Validators
{
    public class DeleteBookCommandValidator:AbstractValidator<DeleteBookCommand>
    {
        private readonly IBookRepository _bookRepository;
        public DeleteBookCommandValidator(IBookRepository bookRepository)
        {
            RuleFor(b => b.id)
                .NotEmpty().WithMessage("BookId is required")
                .MustAsync(MustExists).WithMessage("This book does not exists");
            _bookRepository = bookRepository;
        }
        private async Task<bool> MustExists(int id,CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetAsync(x => x.Id == id, false, true, cancellationToken);
            return book != null ? true : false;
        }
    }
}
