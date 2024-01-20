using MediatR;
using Microsoft.AspNetCore.Http;

namespace ITTradeSoft.Application.UseCases.Projects.Commands
{
    public class CreateProjectCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile ImagePath { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
