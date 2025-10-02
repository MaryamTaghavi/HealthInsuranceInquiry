using HealthInsuranceInquiry.Application.ViewModels;

namespace HealthInsuranceInquiry.Application.Interfaces;

public interface IHealthInsuranceInquiryService
{
    Task<List<GetAllRequestViewModel>> GetAllRequests(CancellationToken cancellationToken);
}
