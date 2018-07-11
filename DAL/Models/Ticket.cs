namespace AirportRESRfulApi.DAL.Models
{
    public class Ticket: Entity
    {
        public decimal Price { set; get; }
        public string FlightNumber { set; get; }
        public int PlaseNumber { set; get; }
    }
}