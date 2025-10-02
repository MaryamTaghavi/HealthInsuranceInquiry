using System.ComponentModel.DataAnnotations;

namespace HealthInsuranceInquiry.Domain.Entities;

public class InsuranceRequest
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal PureInsurance { get; set; }

    #region Navigation Property

    public ICollection<InsuranceRequestCoverage> InsuranceRequestCoverages { get; set; } = new List<InsuranceRequestCoverage>();

    #endregion
}
