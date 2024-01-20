using ITTradeSoft.Domain.Entities.Projects;
using MediatR;

namespace ITTradeSoft.Application.UseCases.Projects.Queries
{
    public class GetImageProjectQuery : IRequest<string>
    {
        public string ImagePath { get; set; }
    }
}
