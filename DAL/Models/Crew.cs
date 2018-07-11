namespace AirportRESRfulApi.DAL.Models
{
    using System.Collections.Generic;
    public class Crew : Entity
    {
        public Pilot Pilot { set; get; }
        public List<Stewardesses> Stewardesses { set; get; }
    }
}