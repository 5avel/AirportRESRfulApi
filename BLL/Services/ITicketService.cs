using AirportRESRfulApi.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportRESRfulApi.BLL.Services
{
    public interface ITicketService
    {
        IEnumerable<TicketDTO> GetTickets();
        TicketDTO GetTicketById(int id);
        TicketDTO MakeTicket(TicketDTO ticket);
        TicketDTO UpdateTicket(TicketDTO ticket);
        bool DeleteTicket(int id);
    }
}
