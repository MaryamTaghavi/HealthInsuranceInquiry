using HealthInsuranceInquiry.Application.Interfaces;
using MediatR;

namespace HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;

public class CreateInsuranceRequestHandler : IRequestHandler<CreateInsuranceRequest, decimal>
{
    private readonly IHealthInsuranceInquiryService _healthInsuranceInquiryService;

    public CreateInsuranceRequestHandler(IHealthInsuranceInquiryService healthInsuranceInquiryService) =>
        _healthInsuranceInquiryService = healthInsuranceInquiryService;

    public async Task<decimal> Handle(CreateInsuranceRequest command, CancellationToken cancellationToken)
    {
        return await _healthInsuranceInquiryService.AddRequest(command, cancellationToken);
    }
}
