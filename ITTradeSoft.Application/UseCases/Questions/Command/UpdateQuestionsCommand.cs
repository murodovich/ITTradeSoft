using MediatR;

namespace ITTradeSoft.Application.UseCases.Questions.Command
{
    public class UpdateQuestionsCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Questionies { get; set; }
        public DateTime Updated { get; set; } = DateTime.Now;
    }
}
