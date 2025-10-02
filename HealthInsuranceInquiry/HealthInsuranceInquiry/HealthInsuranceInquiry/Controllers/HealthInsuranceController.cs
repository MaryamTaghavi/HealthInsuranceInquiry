using HealthInsuranceInquiry.Application.Features.CreateInsuranceRequest;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceInquiry.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthInsuranceController : ControllerBase
    {
        private readonly IMediator _sender;

        /// <summary>
        /// قرعه کشی
        /// </summary>
        /// <param name="sender"></param>
        public HealthInsuranceController(IMediator sender)
        {
            _sender = sender;
        }

        /// <summary>
        /// ثبت درخواست
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        public async Task<IActionResult> Add(CancellationToken cancellationToken)
        {
            var result = await _sender.Send(new CreateInsuranceRequestCommand(), cancellationToken);
            return Ok(result);
        }
    }
}
