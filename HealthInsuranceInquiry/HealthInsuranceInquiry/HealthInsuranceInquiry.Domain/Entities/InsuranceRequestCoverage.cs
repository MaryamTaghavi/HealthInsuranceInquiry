using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HealthInsuranceInquiry.Domain.Enums;

namespace HealthInsuranceInquiry.Domain.Entities;

public class InsuranceRequestCoverage
{
    [Key]
    public int Id { get; init; }
    public int InsuranceRequestId { get; set; }
    public CoverageEnum Coverage { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }

    #region Navigation Property

    [ForeignKey(nameof(InsuranceRequestId))]
    public InsuranceRequest InsuranceRequest { get; set; } = new InsuranceRequest();

    #endregion
}
