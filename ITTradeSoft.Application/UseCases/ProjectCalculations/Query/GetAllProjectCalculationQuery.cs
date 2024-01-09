using ITTradeSoft.Domain.Entities.ProjectCalculations;
using MediatR;

namespace ITTradeSoft.Application.UseCases.ProjectCalculations.Query
{
    public class GetAllProjectCalculationQuery : IRequest<List<ProjectCalculator>>
    {
    }
}
