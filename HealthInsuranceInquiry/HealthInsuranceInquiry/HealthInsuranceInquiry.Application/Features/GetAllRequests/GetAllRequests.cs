using HealthInsuranceInquiry.Application.ViewModels;
using MediatR;

namespace HealthInsuranceInquiry.Application.Features.GetAllRequests;

public record GetAllRequests() : IRequest<List<GetAllRequestViewModel>>;