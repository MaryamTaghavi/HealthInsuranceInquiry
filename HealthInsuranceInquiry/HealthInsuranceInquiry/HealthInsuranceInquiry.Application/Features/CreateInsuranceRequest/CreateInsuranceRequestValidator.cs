using FluentValidation;
using HealthInsuranceInquiry.Application.Helper;

namespace HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;

public class CreateInsuranceRequestValidator : AbstractValidator<CreateInsuranceRequest>
{
    public CreateInsuranceRequestValidator()
    {
        RuleFor(s => s.Name).NotNull().NotEmpty()
            .MaximumLength(150).WithMessage("مقدار عنوان نباید خالی یا بیشتر از 150 کاراکتر باشد!");

        RuleForEach(x => x.RequestCoverages).Must(item =>
        {
            var limits = item.CoverageId.GetLimits();
            return item.Amount >= limits.Min && item.Amount <= limits.Max;
        })
        .WithMessage("مقادیر را درست وارد کنید!");
    }
}