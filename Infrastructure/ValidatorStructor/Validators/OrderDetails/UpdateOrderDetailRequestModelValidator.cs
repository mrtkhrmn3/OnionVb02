using FluentValidation;
using OnionVb02.Application.RequestModels.OrderDetails;

namespace ValidatorStructor.Validators.OrderDetails
{
    public class UpdateOrderDetailRequestModelValidator : AbstractValidator<UpdateOrderDetailRequestModel>
    {
        public UpdateOrderDetailRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id değeri 0'dan büyük olmalıdır.");

            RuleFor(x => x.OrderId)
                .GreaterThan(0).WithMessage("Sipariş Id değeri 0'dan büyük olmalıdır.");

            RuleFor(x => x.ProductId)
                .GreaterThan(0).WithMessage("Ürün Id değeri 0'dan büyük olmalıdır.");
        }
    }
}

