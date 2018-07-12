using AirportRESRfulApi.Shared.DTO;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Services
{
    public interface IFlightsService
    {
        IEnumerable<FlightDto> Get();
        FlightDto GetById(int id);
        FlightDto Make(FlightDto entity);
        FlightDto Update(FlightDto entity);
        bool Delete(int id);
    }
}
