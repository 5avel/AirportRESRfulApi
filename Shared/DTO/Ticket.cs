namespace Shared.DTO
{
    public class Ticket: BaseDTO
    {
        public decimal Price { set; get; }
        public string FlightNumber { set; get; }
    }
}