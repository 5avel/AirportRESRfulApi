﻿namespace AirportRESRfulApi.DAL.Models
{
    using System;
    public class Pilot : Entity
    {
        public int CrewId { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { set; get; }
    }
}