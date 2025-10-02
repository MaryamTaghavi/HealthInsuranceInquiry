using HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;
using HealthInsuranceInquiry.Application.Interfaces;
using HealthInsuranceInquiry.Application.Mappers;
using HealthInsuranceInquiry.Application.ViewModels;
using HealthInsuranceInquiry.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace HealthInsuranceInquiry.Application.Services;

public class HealthInsuranceInquiryService : IHealthInsuranceInquiryService
{
    private readonly AppDbContext _context;

    public HealthInsuranceInquiryService(AppDbContext context) => _context = context;

    public async Task<bool> AddRequest(CreateInsuranceRequest request, CancellationToken cancellationToken)
    {
        try
        {
            _context.Add(request.ToCreateInsuranceRequest());
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<List<GetAllRequestViewModel>> GetAllRequests(CancellationToken cancellationToken)
    {
        var result = await _context.InsuranceRequest.AsNoTracking()
            .Select( r => new GetAllRequestViewModel()).ToListAsync(cancellationToken);

        return result;
    }
}
