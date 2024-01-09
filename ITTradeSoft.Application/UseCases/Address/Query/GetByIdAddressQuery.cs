using ITTradeSoft.Domain.Entities.Address;
using MediatR;

namespace ITTradeSoft.Application.UseCases.Address.Query
{
    public class GetByIdAddressQuery : IRequest<Addres>
    {
        public int Id { get; set; }
    }
}
