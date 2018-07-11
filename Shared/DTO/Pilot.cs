namespace AirportRESRfulApi.Shared.DTO
{
    using System;
    public class Pilot : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { set; get; }
    }
}