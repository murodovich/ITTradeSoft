using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.ProjectCalculations.Query;
using ITTradeSoft.Domain.Entities.ProjectCalculations;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Application.UseCases.ProjectCalculations.Handler
{
    public class GetAllProjectCalculationQueryHandler : IRequestHandler<GetAllProjectCalculationQuery, List<ProjectCalculator>>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetAllProjectCalculationQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProjectCalculator>> Handle(GetAllProjectCalculationQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.ProjectCalculations.ToListAsync();
            return result;
        }
    }
}
