using HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;
using HealthInsuranceInquiry.Application.ViewModels;

namespace HealthInsuranceInquiry.Application.Interfaces;

public interface IHealthInsuranceInquiryService
{
    Task<List<GetAllRequestViewModel>> GetAllRequests(CancellationToken cancellationToken);
    Task<bool> AddRequest(CreateInsuranceRequest request , CancellationToken cancellationToken);
}
