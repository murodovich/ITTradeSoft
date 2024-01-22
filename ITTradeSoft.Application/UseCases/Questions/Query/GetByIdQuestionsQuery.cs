using MediatR;

namespace ITTradeSoft.Application.UseCases.Questions.Query
{
    public class GetByIdQuestionsQuery : IRequest<Domain.Entities.Question.Questions>
    {
        public int Id { get; set; }
    }
}
