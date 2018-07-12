using AirportRESRfulApi.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportRESRfulApi.BLL.Services
{
    public interface ITicketService
    {
        IEnumerable<TicketDto> GetTickets();
        TicketDto GetTicketById(int id);
        TicketDto MakeTicket(TicketDto ticket);
        TicketDto UpdateTicket(TicketDto ticket);
        bool DeleteTicket(int id);
    }
}
