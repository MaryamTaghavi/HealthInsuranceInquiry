using HealthInsuranceInquiry.Application.Interfaces;
using HealthInsuranceInquiry.Application.ViewModels;
using MediatR;

namespace HealthInsuranceInquiry.Application.Features.GetAllRequests;

public class GetAllRequestsHandler : IRequestHandler<GetAllRequests, List<GetAllRequestViewModel>>
{
    private readonly IHealthInsuranceInquiryService _healthInsuranceInquiryService;

    public GetAllRequestsHandler(IHealthInsuranceInquiryService healthInsuranceInquiryService)
    {
        _healthInsuranceInquiryService = healthInsuranceInquiryService;
    }

    public async Task<List<GetAllRequestViewModel>> Handle(GetAllRequests query, CancellationToken cancellationToken)
    {
        return await _healthInsuranceInquiryService.GetAllRequests(cancellationToken);
    }
}