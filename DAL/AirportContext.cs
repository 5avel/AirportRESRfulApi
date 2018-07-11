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
        }

        public List<Ticket> Tickets { private set; get; }
    }
}
