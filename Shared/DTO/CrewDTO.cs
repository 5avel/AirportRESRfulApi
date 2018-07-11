namespace AirportRESRfulApi.Shared.DTO
{
    using System.Collections.Generic;
    public class CrewDTO : BaseDTO
    {
        public Pilot Pilot { set; get; }
        public List<StewardessesDTO> StewardessesDTO { set; get; }
    }
}