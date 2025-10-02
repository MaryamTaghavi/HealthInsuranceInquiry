using HealthInsuranceInquiry.Application.Interfaces;
using MediatR;

namespace HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;

public class CreateInsuranceRequestHandler : IRequestHandler<CreateInsuranceRequest, bool>
{
    private readonly IHealthInsuranceInquiryService _healthInsuranceInquiryService;

    public CreateInsuranceRequestHandler(IHealthInsuranceInquiryService healthInsuranceInquiryService) =>
        _healthInsuranceInquiryService = healthInsuranceInquiryService;

    public async Task<bool> Handle(CreateInsuranceRequest command, CancellationToken cancellationToken)
    {
        await _healthInsuranceInquiryService.AddRequest(command, cancellationToken);
        return true;
    }
}
