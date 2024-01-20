using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Questions.Command;
using MediatR;

namespace ITTradeSoft.Application.UseCases.Questions.Handler
{
    public class UpdatedQuestionsCommandHandler : IRequestHandler<UpdateQuestionsCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public UpdatedQuestionsCommandHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<bool> Handle(UpdateQuestionsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
