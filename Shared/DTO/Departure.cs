using System;
namespace Shared.DTO
{
    public class Departure : BaseDTO
    {
        public string FlightNumber { set; get; }
        public DateTime DepartureTime { set; get; }
        public Crew Crew { set; get; }
    }
}
