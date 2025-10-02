using MediatR;

namespace HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;

public class CreateInsuranceRequestCommandHandler : IRequestHandler<CreateInsuranceRequestCommand, bool>
{

    public CreateInsuranceRequestCommandHandler()
    {
    }

    public async Task<bool> Handle(CreateInsuranceRequestCommand command, CancellationToken cancellationToken)
    {
        return true;
    }
}
