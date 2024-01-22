using MediatR;

namespace ITTradeSoft.Application.UseCases.Questions.Query
{
    public class GetAllQuestionsQuery : IRequest<List<Domain.Entities.Question.Questions>>
    {
    }
}
