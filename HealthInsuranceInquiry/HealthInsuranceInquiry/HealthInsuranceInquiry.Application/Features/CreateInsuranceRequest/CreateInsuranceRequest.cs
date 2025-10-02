using MediatR;

namespace HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;

public record CreateInsuranceRequest() : IRequest<bool>;