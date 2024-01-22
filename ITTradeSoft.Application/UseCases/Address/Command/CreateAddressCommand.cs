using MediatR;

namespace ITTradeSoft.Application.UseCases.Address.Command
{
    public class CreateAddressCommand : IRequest<bool>
    {
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

    }
}
