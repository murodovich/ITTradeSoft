using MediatR;
using Microsoft.AspNetCore.Http;

namespace ITTradeSoft.Application.UseCases.ProjectCalculations.Command
{
    public class CreateProjectCalculationCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IFormFile FilePath { get; set; }
    }
}
