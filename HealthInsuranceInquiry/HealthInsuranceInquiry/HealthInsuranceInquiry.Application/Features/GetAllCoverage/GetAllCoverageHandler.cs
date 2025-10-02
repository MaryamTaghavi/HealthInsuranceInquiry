using HealthInsuranceInquiry.Application.ViewModels;
using HealthInsuranceInquiry.Domain.Enums;
using Humanizer;
using MediatR;

namespace HealthInsuranceInquiry.Application.Features.GetAllCoverage;

public class GetAllCoverageHandler : IRequestHandler<GetAllCoverage, List<CoverageViewModel>>
{
    public async Task<List<CoverageViewModel>> Handle(GetAllCoverage query, CancellationToken cancellationToken)
    {
        return Enum.GetValues(typeof(CoverageEnum))
               .Cast<CoverageEnum>()
               .Select(e => new CoverageViewModel((int)e, e.Humanize()))
               .ToList();
    }
}
