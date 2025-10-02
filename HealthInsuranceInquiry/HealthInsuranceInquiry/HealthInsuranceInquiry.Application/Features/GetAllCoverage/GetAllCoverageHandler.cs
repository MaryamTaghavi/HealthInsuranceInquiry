using HealthInsuranceInquiry.Application.Helper;
using HealthInsuranceInquiry.Application.ViewModels;
using HealthInsuranceInquiry.Domain.Enums;
using MediatR;

namespace HealthInsuranceInquiry.Application.Features.GetAllCoverage;

public class GetAllCoverageHandler : IRequestHandler<GetAllCoverage, List<CoverageViewModel>>
{
    public Task<List<CoverageViewModel>> Handle(GetAllCoverage query, CancellationToken cancellationToken)
    {
        var result = Enum.GetValues(typeof(CoverageEnum))
                .Cast<CoverageEnum>()
                .Select(e => new CoverageViewModel((int)e, e.GetDescription()))
                .ToList();

        return Task.FromResult(result);
    }
}
