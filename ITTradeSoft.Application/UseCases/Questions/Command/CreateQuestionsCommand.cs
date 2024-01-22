using MediatR;

namespace ITTradeSoft.Application.UseCases.Questions.Command
{
    public class CreateQuestionsCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Questionies { get; set; }
    }
}
