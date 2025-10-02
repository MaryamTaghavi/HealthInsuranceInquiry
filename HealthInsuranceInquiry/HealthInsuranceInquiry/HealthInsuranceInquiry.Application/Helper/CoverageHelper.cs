using HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;
using HealthInsuranceInquiry.Domain.Enums;

namespace HealthInsuranceInquiry.Application.Helper;

public static class CoverageHelper
{
    public static (decimal Min, decimal Max) GetLimits(this int coverage)
    {
        return coverage switch
        {
            (int)CoverageEnum.Surgical => (5000m, 500_000_000m),
            (int)CoverageEnum.Dental => (4000m, 400_000_000m),
            (int)CoverageEnum.Inpatient => (2000m, 200_000_000m),
            _ => throw new ArgumentOutOfRangeException(nameof(coverage), "Unknown coverage type")
        };
    }

    public static decimal CalculatePremium(this Coverage coverage)
    {
        return coverage.CoverageId switch
        {
            (int)CoverageEnum.Surgical => coverage.Amount * 0.00520m,
            (int)CoverageEnum.Dental => coverage.Amount * 0.00420m,
            (int)CoverageEnum.Inpatient => coverage.Amount * 0.0050m,
            _ => throw new ArgumentOutOfRangeException(nameof(coverage.CoverageId), "پوشش نامعتبر است.")
        };
    }
}