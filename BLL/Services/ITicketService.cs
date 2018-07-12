using AirportRESRfulApi.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportRESRfulApi.BLL.Services
{
    public interface ITicketService
    {
        IEnumerable<TicketDto> Get();
        TicketDto GetById(int id);
        TicketDto Make(TicketDto entity);
        TicketDto Update(TicketDto entity);
        bool Delete(int id);
    }
}
