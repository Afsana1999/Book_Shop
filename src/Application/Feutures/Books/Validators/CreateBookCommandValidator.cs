using BookShop.Application.Feutures.Books.Commands.CreateBookCommand;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Application.Feutures.Books.Validators;

public class CreateBookCommandValidator:AbstractValidator<CreateBookCommand>
{
    private readonly IBookRepository _bookRepository;



    public CreateBookCommandValidator(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;

        RuleFor(c => c.BookName)
            .NotEmpty().WithMessage("Book is required")
            .MaximumLength(200).WithMessage("BookName must not exceed 200 characters");
            //.MustAsync(BeUniqName).WithMessage("The specific BookName already exists");

        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Description is required");

        RuleFor(c => c.Quantity)
            .NotEmpty().WithMessage("Quantity is required")
            .GreaterThan(1).WithMessage("Quantity must be greater than 1");
    }

    //public async Task<bool> BeUniqName(string bookName, CancellationToken cancellationToken)
    //{
    //    var entity = await _bookRepository.GetAsync(x => x.BookName == bookName , false, false, cancellationToken);
    //    return entity == null;

    //}
}
