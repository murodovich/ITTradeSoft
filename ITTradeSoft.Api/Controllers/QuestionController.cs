using ITTradeSoft.Application.UseCases.Questions.Command;
using ITTradeSoft.Application.UseCases.Questions.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITTradeSoft.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QuestionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllQuestionsAsync()
        {
            var result = await _mediator.Send(new GetAllQuestionsQuery());
            return Ok(result);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateQuestionsAsync(CreateQuestionsCommand command)
        {
            await _mediator.Send(command);
            return Ok("created");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdQuestionsAsync(int Id)
        {
            var result = await _mediator.Send(new GetByIdQuestionsQuery() { Id = Id});
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateQuestionsAsync(UpdateQuestionsCommand command) 
        {
            await _mediator.Send(command);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteQuestionAsync(int Id)
        {
            await _mediator.Send(new DeleteQuestionsCommand() { Id = Id });
            return Ok("Deleted");
        }
    }
}
