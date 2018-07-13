﻿namespace AirportRESRfulApi.DAL.Models
{
    using System.Collections.Generic;
    public class Crew : Entity
    {
        public int DepartureId { get; set; }
        public Pilot Pilot { set; get; }
        public List<Stewardess> Stewardesses { set; get; }
    }
}