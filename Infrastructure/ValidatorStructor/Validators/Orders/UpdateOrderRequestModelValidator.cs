using FluentValidation;
using OnionVb02.Application.RequestModels.Orders;

namespace ValidatorStructor.Validators.Orders
{
    public class UpdateOrderRequestModelValidator : AbstractValidator<UpdateOrderRequestModel>
    {
        public UpdateOrderRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id değeri 0'dan büyük olmalıdır.");

            RuleFor(x => x.ShippingAddress)
                .NotEmpty().WithMessage("Teslimat adresi boş olamaz.")
                .NotNull().WithMessage("Teslimat adresi zorunludur.")
                .MinimumLength(10).WithMessage("Teslimat adresi en az 10 karakter olmalıdır.")
                .MaximumLength(500).WithMessage("Teslimat adresi en fazla 500 karakter olabilir.");
        }
    }
}

