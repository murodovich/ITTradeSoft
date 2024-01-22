using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Projects.Commands;
using ITTradeSoft.Domain.Exceptions.ImageExceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Application.UseCases.Projects.Handler
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public DeleteProjectCommandHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Projects.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new ImageNotValid();
            _dbContext.Projects.Remove(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
