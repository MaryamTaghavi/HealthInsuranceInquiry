using MediatR;

namespace HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;

public record CreateInsuranceRequest
(
    string Name,
    decimal Price,
    List<Coverage> RequestCoverages
) : IRequest<bool>;

public record Coverage(int CoverageId, decimal Amount);