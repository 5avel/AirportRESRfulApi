namespace DAL.Models
{
    public class Ticket: Entity
    {
        public decimal Price { set; get; }
        public string FlightNumber { set; get; }
    }
}