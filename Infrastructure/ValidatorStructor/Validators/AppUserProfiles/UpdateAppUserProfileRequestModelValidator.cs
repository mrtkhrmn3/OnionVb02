using FluentValidation;
using OnionVb02.Application.RequestModels.AppUserProfiles;

namespace ValidatorStructor.Validators.AppUserProfiles
{
    public class UpdateAppUserProfileRequestModelValidator : AbstractValidator<UpdateAppUserProfileRequestModel>
    {
        public UpdateAppUserProfileRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id değeri 0'dan büyük olmalıdır.");

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Ad boş olamaz.")
                .NotNull().WithMessage("Ad zorunludur.")
                .MinimumLength(2).WithMessage("Ad en az 2 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Ad en fazla 50 karakter olabilir.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Soyad boş olamaz.")
                .NotNull().WithMessage("Soyad zorunludur.")
                .MinimumLength(2).WithMessage("Soyad en az 2 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Soyad en fazla 50 karakter olabilir.");

            RuleFor(x => x.AppUserId)
                .GreaterThan(0).WithMessage("Kullanıcı Id değeri 0'dan büyük olmalıdır.");
        }
    }
}

