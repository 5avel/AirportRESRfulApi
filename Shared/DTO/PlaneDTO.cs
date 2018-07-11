namespace AirportRESRfulApi.Shared.DTO
{
    using System;
    public class PlaneDTO : BaseDTO
    {
        public string Name { set; get; }
        public PlaneTypeDTO Type { set; get; }
        public DateTime ReleaseDate { set; get; }
    }
}
