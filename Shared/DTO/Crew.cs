namespace AirportRESRfulApi.Shared.DTO
{
    using System.Collections.Generic;
    public class Crew : BaseDTO
    {
        public Pilot Pilot { set; get; }
        public List<Stewardesses> Stewardesses { set; get; }
    }
}