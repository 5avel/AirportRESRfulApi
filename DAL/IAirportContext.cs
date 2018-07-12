using AirportRESRfulApi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportRESRfulApi.DAL
{
    public interface IAirportContext
    {
        List<Flight> Flights { get; }
        List<Departure> Departures { get; }
        List<Ticket> Tickets { get; }
        List<Crew> Crews { get; }
        List<Pilot> Pilots {  get; }
    }
}
