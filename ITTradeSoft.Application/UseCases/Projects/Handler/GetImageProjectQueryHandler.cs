using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.FileServices;
using ITTradeSoft.Application.UseCases.Projects.Queries;
using ITTradeSoft.Domain.Exceptions.ImageExceptions;
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
            var imagepath = await _fileService.GetImageAsync(request.ImagePath);
            if (imagepath == null) throw new ImageNotValid();

            return "";


        }
    }
}
