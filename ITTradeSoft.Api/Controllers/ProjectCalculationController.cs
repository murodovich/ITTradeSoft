using ITTradeSoft.Application.UseCases.ProjectCalculations.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITTradeSoft.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectCalculationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectCalculationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async ValueTask<IActionResult> CreateProjectCalculator(CreateProjectCalculationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Created");
        }

    }
}
