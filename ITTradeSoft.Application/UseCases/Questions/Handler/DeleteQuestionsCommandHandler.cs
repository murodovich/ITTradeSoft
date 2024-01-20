using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Questions.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Application.UseCases.Questions.Handler
{
    public class DeleteQuestionsCommandHandler : IRequestHandler<DeleteQuestionsCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public DeleteQuestionsCommandHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteQuestionsCommand request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Questions.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new Exception();

            _dbContext.Questions.Remove(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
