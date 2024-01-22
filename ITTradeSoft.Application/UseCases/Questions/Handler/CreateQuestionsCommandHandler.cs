using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Questions.Command;
using ITTradeSoft.Domain.Entities.Question;
using MediatR;

namespace ITTradeSoft.Application.UseCases.Questions.Handler
{
    public class CreateQuestionsCommandHandler : IRequestHandler<CreateQuestionsCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public CreateQuestionsCommandHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(CreateQuestionsCommand request, CancellationToken cancellationToken)
        {
            var result = new Domain.Entities.Question.Questions()
            {
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                Questionies = request.Questionies,
                CreatedAt = DateTime.UtcNow,

            };

            await _dbContext.Questions.AddAsync(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
