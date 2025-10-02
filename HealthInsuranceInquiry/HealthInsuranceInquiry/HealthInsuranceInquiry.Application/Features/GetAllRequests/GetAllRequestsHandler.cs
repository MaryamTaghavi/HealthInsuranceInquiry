using HealthInsuranceInquiry.Application.ViewModels;
using MediatR;

namespace HealthInsuranceInquiry.Application.Features.GetAllRequests;

public class GetAllRequestsHandler : IRequestHandler<GetAllRequests, List<GetAllRequestViewModel>>
{

    public GetAllRequestsHandler()
    {
    }

    public async Task<List<GetAllRequestViewModel>> Handle(GetAllRequests query, CancellationToken cancellationToken)
    {
        return null;
    }
}