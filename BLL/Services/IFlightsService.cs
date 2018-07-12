using AirportRESRfulApi.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

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
