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

            Departures = new List<Departure>
            {
                new Departure
                {
                    Id = 1,
                    Flightid = 1,
                    FlightNumber = "QW11",
                    DepartureTime = DateTime.Now,
                    Plane = null,
                    Crew = null

                },
                new Departure
                {
                    Id = 2,
                    Flightid = 2,
                    FlightNumber = "QW13",
                    DepartureTime = DateTime.Now,
                    Plane = null,
                    Crew = null
                }
            };

            Crews = new List<Crew>
            {
                new Crew
                {
                    Id = 1,
                    Pilot = null,
                    Stewardesses = new List<Stewardess>()
                },
                new Crew
                {
                    Id = 2,
                    Pilot = null,
                    Stewardesses = new List<Stewardess>()
                }
            };

            Pilots = new List<Pilot>
            {
                new Pilot
                {
                    Id = 1,
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Birthday = new DateTime(1987, 1, 24, 0, 0, 0),
                    CrewId = 1,
                    Experience = 8
                   
                },
                new Pilot
                {
                    Id = 2,
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Birthday = new DateTime(1977, 1, 24, 0, 0, 0),
                    CrewId = 2,
                    Experience = 3
                }
            };
        }

        public List<Flight> Flights { private set; get; }
        public List<Departure> Departures { private set; get; }
        public List<Ticket> Tickets { private set; get; }
        public List<Crew>  Crews { private set; get; }
        public List<Pilot> Pilots { private set; get; }


    }
}
