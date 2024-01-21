using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.FileServices;
using ITTradeSoft.Application.UseCases.Projects.Queries;
using MediatR;

namespace ITTradeSoft.Application.UseCases.Projects.Handler
{
    public class GetImageProjectQueryHandler : IRequestHandler<GetImageProjectQuery, string>
    {
        private readonly ITradeSoftDBContext _dbContext;
        private readonly IFileService _fileService;

        public GetImageProjectQueryHandler(ITradeSoftDBContext dbContext, IFileService fileService)
        {
            _dbContext = dbContext;
            _fileService = fileService;
        }

        public async Task<string> Handle(GetImageProjectQuery request, CancellationToken cancellationToken)
        {
            await _fileService.GetImageAsync(request.ImagePath);
            return string.Empty;


        }
    }
}
