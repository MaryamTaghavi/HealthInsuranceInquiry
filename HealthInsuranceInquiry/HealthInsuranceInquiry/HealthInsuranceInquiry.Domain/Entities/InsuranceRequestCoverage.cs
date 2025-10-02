using System.ComponentModel.DataAnnotations;
using HealthInsuranceInquiry.Domain.Enums;

namespace HealthInsuranceInquiry.Domain.Entities;

public class InsuranceRequestCoverage
{
    [Key]
    public int Id { get; set; }
    public int InsuranceRequestId { get; set; }
    public CoverageEnum Coverage { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }

    #region Navigation Property

    public InsuranceRequest InsuranceRequest { get; set; }

    #endregion
}
