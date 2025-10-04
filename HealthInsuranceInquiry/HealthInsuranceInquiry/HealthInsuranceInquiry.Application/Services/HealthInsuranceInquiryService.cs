using HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;
using HealthInsuranceInquiry.Application.Interfaces;
using HealthInsuranceInquiry.Application.Mappers;
using HealthInsuranceInquiry.Application.ViewModels;
using HealthInsuranceInquiry.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace HealthInsuranceInquiry.Application.Services;

public class HealthInsuranceInquiryService : IHealthInsuranceInquiryService
{
    private readonly AppDbContext _context;

    public HealthInsuranceInquiryService(AppDbContext context) => _context = context;

    public async Task<decimal> AddRequest(CreateInsuranceRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var insuranceRequest = request.ToCreateInsuranceRequest();
            _context.InsuranceRequest.Add(insuranceRequest);
            await _context.SaveChangesAsync(cancellationToken);
            return insuranceRequest.PureInsurance;
        }
        catch
        {
            return 0;
        }
    }

    public async Task<List<GetAllRequestViewModel>> GetAllRequests(CancellationToken cancellationToken)
    {
        var result = await _context.InsuranceRequest.AsNoTracking()
            .Include( r => r.InsuranceRequestCoverages)
            .Select( r => r.ToGetRequestCoverage()).ToListAsync(cancellationToken);

        return result;
    }
}
