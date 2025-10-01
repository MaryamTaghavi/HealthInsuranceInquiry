using HealthInsuranceInquiry.Domain.Enums;

namespace HealthInsuranceInquiry.Application.Helper;

public static class CoverageHelper
{
    public static (decimal Min, decimal Max) GetLimits(this CoverageEnum coverage)
    {
        return coverage switch
        {
            CoverageEnum.Surgical => (5000m, 500_000_000m),
            CoverageEnum.Dental => (4000m, 400_000_000m),
            CoverageEnum.Inpatient => (2000m, 200_000_000m),
            _ => throw new ArgumentOutOfRangeException(nameof(coverage), "Unknown coverage type")
        };
    }
}