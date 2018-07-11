namespace AirportRESRfulApi.DAL.Models
{
    using System;
    public class Plane : Entity
    {
        public string Name { set; get; }
        public PlaneType Type { set; get; }
        public DateTime ReleaseDate { set; get; }
    }
}
