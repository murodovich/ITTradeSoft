using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Address.Query;
using ITTradeSoft.Domain.Entities.Address;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Application.UseCases.Address.Handler
{
    public class GetByIdAddressQueryHandler : IRequestHandler<GetByIdAddressQuery, Addres>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetByIdAddressQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Addres> Handle(GetByIdAddressQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Addreses.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new Exception();
            return result;         
        }
    }
}
