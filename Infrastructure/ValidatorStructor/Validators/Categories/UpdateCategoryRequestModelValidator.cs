using FluentValidation;
using OnionVb02.Application.RequestModels.Categories;

namespace ValidatorStructor.Validators.Categories
{
    public class UpdateCategoryRequestModelValidator : AbstractValidator<UpdateCategoryRequestModel>
    {
        public UpdateCategoryRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id değeri 0'dan büyük olmalıdır.");

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

