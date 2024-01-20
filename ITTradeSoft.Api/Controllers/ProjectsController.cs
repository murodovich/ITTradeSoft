using ITTradeSoft.Application.UseCases.Projects.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITTradeSoft.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ProjectsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateProjectAsync([FromForm]CreateProjectCommand createProject)
        {
            await _mediator.Send(createProject);
            return Ok("created");
        }
    }
}
