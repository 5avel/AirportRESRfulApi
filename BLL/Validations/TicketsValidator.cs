using AirportRESRfulApi.Shared.DTO;
using FluentValidation;

namespace AirportRESRfulApi.BLL.Validations
{
    public class TicketsValidator : AbstractValidator<TicketDto>
    {
        public TicketsValidator()
        {
            RuleFor(ticketDto => ticketDto.FlightNumber)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(10);

            RuleFor(ticketDto => ticketDto.FlightId)
                .NotEqual(0);

            
        }
    }
}
