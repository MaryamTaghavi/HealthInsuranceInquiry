using MediatR;

namespace HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;

public record CreateInsuranceRequestCommand() : IRequest<bool>;