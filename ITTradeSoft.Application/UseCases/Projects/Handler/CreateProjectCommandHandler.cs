using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.FileServices;
using ITTradeSoft.Application.UseCases.Projects.Commands;
using ITTradeSoft.Domain.Entities.Projects;
using MediatR;

namespace ITTradeSoft.Application.UseCases.Projects.Handler
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand,bool>
    {
        private readonly ITradeSoftDBContext _dbContext;
        private readonly IFileService _fileService;

        public CreateProjectCommandHandler(IFileService fileService, ITradeSoftDBContext dbContext)
        {
            _fileService = fileService;
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            string filepage = await _fileService.UploadImageAsync(request.ImagePath);

            var result = new Project()
            {
                Name = request.Name,
                Description = request.Description,
                ImagePath = filepage,
                CreatedAt = DateTime.UtcNow,
            };
            
            await _dbContext.Projects.AddAsync(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;


        }
    }
}
