namespace HealthInsuranceInquiry.Application.ViewModels;

public class GetAllRequestViewModel
{
    /// <summary>
    /// شناسه
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// عنوان درخواست
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// لیست پوشش ها
    /// </summary>
    public List<InsuranceRequestCoverageViewModel> Coverages { get; set; }
}
