using FluentValidation;
using product.DTos;

namespace product.Validators
{
    public class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The Name field is required.")
                .Length(5, 30).WithMessage("Name must be between 5 and 30 characters.");

            RuleFor(x => x.Price)
                .NotEmpty().WithMessage("The Price field is required.")
                .InclusiveBetween(20, 3000).WithMessage("Price must be between 20 and 3000.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("The Description field is required.")
                .MinimumLength(10).WithMessage("Description must be at least 10 characters.");
        }
    }
}
