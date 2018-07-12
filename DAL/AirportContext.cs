using AirportRESRfulApi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportRESRfulApi.DAL
{
    public class AirportContext : IAirportContext
    {
        public AirportContext()
        {
            Tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    FlightNumber = "QW11",
                    PlaseNumber = 1,
                    Price = 55,
                    IsSold = false

                },
                new Ticket
                {
                    Id = 2,
                    FlightNumber = "QW11",
                    PlaseNumber = 2,
                    Price = 55,
                    IsSold = true
                }
            };

            Flights = new List<Flight>
            {
                new Flight
                {
                    Id = 1,
                    DepartureNumber = "QW11",
                    DeparturePoint = "London",
                    DepartureTime = DateTime.Now,
                    DestinationPoint = "Ukraine",
                    ArrivalTime = DateTime.Now + TimeSpan.FromHours(5),
                    Tickets = null

                },
                new Flight
                {
                    Id = 2,
                    DepartureNumber = "QW13",
                    DeparturePoint = "Ukraine",
                    DepartureTime = DateTime.Now,
                    DestinationPoint = "London",
                    ArrivalTime = DateTime.Now + TimeSpan.FromHours(5),
                    Tickets = Tickets
                }
            };
        }

        public List<Flight> Flights { private set; get; }
        public List<Ticket> Tickets { private set; get; }
    }
}
