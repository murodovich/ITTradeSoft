using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Questions.Query;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Application.UseCases.Questions.Handler
{
    public class GetByIdQuestionsQueryHandler : IRequestHandler<GetByIdQuestionsQuery, Domain.Entities.Question.Questions>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetByIdQuestionsQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Domain.Entities.Question.Questions> Handle(GetByIdQuestionsQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Questions.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new Exception();
            return result;
        }
    }
}
