using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Projects.Queries;
using ITTradeSoft.Domain.Entities.Projects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Application.UseCases.Projects.Handler
{
    public class GetAllProjectQueryHandler : IRequestHandler<GetAllProjectQuery, List<Project>>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetAllProjectQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Project>> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Projects.ToListAsync(cancellationToken);
            return result;
        }
    }
}
