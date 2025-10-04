using HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;
using HealthInsuranceInquiry.Application.Features.GetAllCoverage;
using HealthInsuranceInquiry.Application.Features.GetAllRequests;
using HealthInsuranceInquiry.Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceInquiry.Controllers; 

[ApiController]
[Route("[controller]")]
public class HealthInsuranceController : ControllerBase
{
    private readonly IMediator _sender;

    /// <summary>
    /// استعلام حق بیمه درمان
    /// </summary>
    /// <param name="sender"></param>
    public HealthInsuranceController(IMediator sender) =>  _sender = sender;

    /// <summary>
    /// ثبت درخواست
    /// </summary>
    /// <remarks>
    /// ## پوشش جراحی :
    /// این پوشش حداقل 5000 و حداکثر 500000000 سرمایه میتواند داشته باشد.
    /// ## پوشش فوت دندان پزشکی :
    /// این پوشش حداقل 4000 و حداکثر 400000000 سرمایه میتواند داشته باشد.
    /// ## پوشش بستری :
    /// این پوشش حداقل 2000 و حداکثر 200000000 سرمایه میتواند داشته باشد.
    /// ##
    /// </remarks>
    /// <param name="cancellationToken"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("CreateRequest")]
    [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
    public async Task<IActionResult> Add(CreateInsuranceRequest request , CancellationToken cancellationToken)
    {
        var result = await _sender.Send(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// لیست درخواست ها
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("GetAll")]
    [ProducesResponseType(typeof(List<GetAllRequestViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new GetAllRequests(), cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// لیست پوشش ها
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("GetAllCoverage")]
    [ProducesResponseType(typeof(List<CoverageViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllCoverage(CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new GetAllCoverage(), cancellationToken);
        return Ok(result);
    }
}
