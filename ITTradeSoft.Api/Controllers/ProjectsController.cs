using ITTradeSoft.Application.UseCases.Projects.Commands;
using ITTradeSoft.Application.UseCases.Projects.Queries;
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

        [HttpGet]
        public async ValueTask<IActionResult> GetAllProjectAsync() 
        {
            var result = await _mediator.Send(new GetAllProjectQuery());
            return Ok(result);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateProjectAsync([FromForm]CreateProjectCommand createProject)
        {
            await _mediator.Send(createProject);
            return Ok("created");
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteProjectAsync(int id)
        {
            await _mediator.Send(new DeleteProjectCommand() { Id = id});
            return Ok("Deleted");
        }

    }
}
