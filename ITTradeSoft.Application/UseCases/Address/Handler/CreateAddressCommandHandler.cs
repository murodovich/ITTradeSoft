using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Application.UseCases.Address.Command;
using ITTradeSoft.Domain.Entities.Address;
using MediatR;

namespace ITTradeSoft.Application.UseCases.Address.Handler
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public CreateAddressCommandHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var result = new Addres()
            {
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                City = request.City,
                CreatedAt = DateTime.UtcNow,
            };

            await _dbContext.Addreses.AddAsync(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
