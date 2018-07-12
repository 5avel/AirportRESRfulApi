using AirportRESRfulApi.Shared.DTO;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Interfaces
{
    public interface ITicketsService
    {
        IEnumerable<TicketDto> Get();
        TicketDto GetById(int id);
        TicketDto Make(TicketDto entity);
        TicketDto Update(TicketDto entity);
        bool Delete(int id);
    }
}
