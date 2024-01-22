using ITTradeSoft.Domain.Entities.Projects;
using MediatR;

namespace ITTradeSoft.Application.UseCases.Projects.Queries
{
    public class GetAllProjectQuery : IRequest<List<Project>>
    {
    }
}
