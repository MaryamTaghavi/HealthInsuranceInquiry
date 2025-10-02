using HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;
using HealthInsuranceInquiry.Application.Helper;
using HealthInsuranceInquiry.Domain.Entities;
using HealthInsuranceInquiry.Domain.Enums;

namespace HealthInsuranceInquiry.Application.Mappers;

public static class HealthInsuranceMapper
{
    public static InsuranceRequest ToCreateInsuranceRequest(this CreateInsuranceRequest request) =>
        new()
        {
            InsuranceRequestCoverages = request.RequestCoverages.ToCreateRequestCoverage().ToList(),
            Name = request.Name,
            Price = request.Price
        };

    public static IEnumerable<InsuranceRequestCoverage> ToCreateRequestCoverage(this List<Coverage> coverages)
    {
        foreach (var item in coverages)
        {
            yield return new()
            {
                CreatedDate = DateTime.Now,
                Coverage = EnumHelper.GetEnumFromId<CoverageEnum>(item.CoverageId),
                Price = item.Amount
            };
        }
    }
}
