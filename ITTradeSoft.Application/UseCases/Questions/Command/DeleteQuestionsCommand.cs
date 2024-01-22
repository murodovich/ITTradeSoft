using MediatR;

namespace ITTradeSoft.Application.UseCases.Questions.Command
{
    public class DeleteQuestionsCommand : IRequest<bool>
    {
        public int  Id { get; set; }
    }
}
