using HealthInsuranceInquiry.Application.ViewModels;
using MediatR;

namespace HealthInsuranceInquiry.Application.Features.GetAllCoverage;

public record GetAllCoverage() : IRequest<List<CoverageViewModel>>;