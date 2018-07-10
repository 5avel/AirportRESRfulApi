using System;

namespace Shared.DTO
{
    public class Flight : BaseDTO
    {
        public string FlightNumber { set; get; } 
        public string DeparturePoint { set; get; }
        public DateTime DepartureTime { set; get; }
        public string DestinationPoint { set; get; }
        public DateTime ArrivalTime { set; get; }
        public Ticket Ticket { set; get; }
    }
}
