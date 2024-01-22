using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Questions.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Application.UseCases.Questions.Handler
{
    public class UpdatedQuestionsCommandHandler : IRequestHandler<UpdateQuestionsCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public UpdatedQuestionsCommandHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(UpdateQuestionsCommand request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Questions.FirstOrDefaultAsync(x => x.Id == request.Id);
            //if (result == null) throw new QuestionsNotFoundExceptions();

            result.Name = request.Name;
            result.PhoneNumber = request.PhoneNumber;
            result.Questionies = request.Questionies;
            result.UpdatedAt = DateTime.UtcNow;

            _dbContext.Questions.Update(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
