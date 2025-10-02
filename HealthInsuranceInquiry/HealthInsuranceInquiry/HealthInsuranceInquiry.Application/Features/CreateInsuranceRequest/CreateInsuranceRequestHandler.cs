using MediatR;

namespace HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;

public class CreateInsuranceRequestHandler : IRequestHandler<CreateInsuranceRequest, bool>
{

    public CreateInsuranceRequestHandler()
    {
    }

    public async Task<bool> Handle(CreateInsuranceRequest command, CancellationToken cancellationToken)
    {
        return true;
    }
}
