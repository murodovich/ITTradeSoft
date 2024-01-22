using MediatR;

namespace ITTradeSoft.Application.UseCases.Projects.Commands
{
    public class DeleteProjectCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
