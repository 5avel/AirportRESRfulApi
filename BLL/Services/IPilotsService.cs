using AirportRESRfulApi.Shared.DTO;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Services
{
    public interface IPilotsService
    {
        IEnumerable<PilotDto> Get();
        PilotDto GetById(int id);
        PilotDto Make(PilotDto entity);
        PilotDto Update(PilotDto entity);
        bool Delete(int id);
    }
}
