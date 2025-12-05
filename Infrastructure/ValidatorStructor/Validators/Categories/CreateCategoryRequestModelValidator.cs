using FluentValidation;
using OnionVb02.Application.RequestModels.Categories;

namespace ValidatorStructor.Validators.Categories
{
    public class CreateCategoryRequestModelValidator : AbstractValidator<CreateCategoryRequestModel>
    {
        public CreateCategoryRequestModelValidator()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("Kategori adı boş olamaz.")
                .NotNull().WithMessage("Kategori adı zorunludur.")
                .MinimumLength(2).WithMessage("Kategori adı en az 2 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Kategori adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Açıklama en fazla 500 karakter olabilir.")
                .When(x => !string.IsNullOrEmpty(x.Description));
        }
    }
}

