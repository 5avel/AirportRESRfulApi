using System;
using System.Collections.Generic;
using System.Text;
using AirportRESRfulApi.Shared.DTO;
using FluentValidation;

namespace AirportRESRfulApi.BLL.Validations
{
    public class TicketValidator : AbstractValidator<TicketDto>
    {
        public TicketValidator()
        {
            RuleFor(ticketDto => ticketDto.FlightNumber)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(10);
        }
    }
}
