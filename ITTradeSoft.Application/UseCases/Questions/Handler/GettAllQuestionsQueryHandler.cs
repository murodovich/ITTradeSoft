using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Questions.Query;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Application.UseCases.Questions.Handler
{
    public class GettAllQuestionsQueryHandler : IRequestHandler<GetAllQuestionsQuery, List<Domain.Entities.Question.Questions>>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GettAllQuestionsQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Domain.Entities.Question.Questions>> Handle(GetAllQuestionsQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Questions.ToListAsync();
            return result;
        }
    }
}
