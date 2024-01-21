using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.FileServices;
using ITTradeSoft.Application.UseCases.ProjectCalculations.Command;
using ITTradeSoft.Domain.Entities.ProjectCalculations;
using MediatR;

namespace ITTradeSoft.Application.UseCases.ProjectCalculations.Handler
{
    public class CreateProjectCalculationCommandHandler : IRequestHandler<CreateProjectCalculationCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;
        private readonly IFileService _fileService;

        public CreateProjectCalculationCommandHandler(ITradeSoftDBContext dbContext, IFileService fileService)
        {
            _dbContext = dbContext;
            _fileService = fileService;
        }

        public async Task<bool> Handle(CreateProjectCalculationCommand request, CancellationToken cancellationToken)
        {
            string filepage = await _fileService.UploadFileAsync(request.FilePath);

            var result = new ProjectCalculator()
            {
                Name = request.Name,
                Email = request.Email,
                FilePath = filepage,
                CreatedAt = DateTime.UtcNow,
            };

            await _dbContext.ProjectCalculations.AddAsync(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
