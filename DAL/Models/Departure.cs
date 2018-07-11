namespace DAL.Models
{
    using System;
    public class Departure : Entity
    {
        public string FlightNumber { set; get; }
        public DateTime DepartureTime { set; get; }
        public Crew Crew { set; get; }
    }
}
