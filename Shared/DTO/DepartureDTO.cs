using System;
namespace AirportRESRfulApi.Shared.DTO
{
    public class DepartureDTO : BaseDTO
    {
        public string FlightNumber { set; get; }
        public DateTime DepartureTime { set; get; }
        public CrewDTO CrewDTO { set; get; }
    }
}
