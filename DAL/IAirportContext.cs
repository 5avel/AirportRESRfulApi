using AirportRESRfulApi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportRESRfulApi.DAL
{
    public interface IAirportContext
    {
        List<Ticket> Tickets { get; }
    }
}
