namespace AirportRESRfulApi.Shared.DTO
{
    using System;
    public class StewardessesDTO : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}