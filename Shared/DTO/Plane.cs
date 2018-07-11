namespace AirportRESRfulApi.Shared.DTO
{
    using System;
    public class Plane : BaseDTO
    {
        public string Name { set; get; }
        public PlaneType Type { set; get; }
        public DateTime ReleaseDate { set; get; }
    }
}
