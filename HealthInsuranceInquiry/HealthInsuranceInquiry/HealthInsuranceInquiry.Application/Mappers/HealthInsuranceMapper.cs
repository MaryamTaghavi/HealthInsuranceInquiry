using HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;
using HealthInsuranceInquiry.Application.Helper;
using HealthInsuranceInquiry.Application.ViewModels;
using HealthInsuranceInquiry.Domain.Entities;
using HealthInsuranceInquiry.Domain.Enums;
using MediatR;

namespace HealthInsuranceInquiry.Application.Mappers;

public static class HealthInsuranceMapper
{
    public static InsuranceRequest ToCreateInsuranceRequest(this CreateInsuranceRequest request) =>
        new()
        {
            InsuranceRequestCoverages = request.RequestCoverages.ToCreateRequestCoverage().ToList(),
            Name = request.Name
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

    public static GetAllRequestViewModel ToGetRequestCoverage(this InsuranceRequest request)
    {
        return new GetAllRequestViewModel()
        {
            Id = request.Id,
            Name = request.Name,
            Coverages = request.InsuranceRequestCoverages.Select(c => new InsuranceRequestCoverageViewModel()
            {
                CoverageId = (int)c.Coverage,
                Price = c.Price
            }).ToList()
        };
    }
}
