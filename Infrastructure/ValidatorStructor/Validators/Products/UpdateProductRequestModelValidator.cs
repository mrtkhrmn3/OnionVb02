using FluentValidation;
using OnionVb02.Application.RequestModels.Products;

namespace ValidatorStructor.Validators.Products
{
    public class UpdateProductRequestModelValidator : AbstractValidator<UpdateProductRequestModel>
    {
        public UpdateProductRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id değeri 0'dan büyük olmalıdır.");

            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("Ürün adı boş olamaz.")
                .NotNull().WithMessage("Ürün adı zorunludur.")
                .MinimumLength(2).WithMessage("Ürün adı en az 2 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Ürün adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.UnitPrice)
                .GreaterThan(0).WithMessage("Birim fiyat 0'dan büyük olmalıdır.");
        }
    }
}

