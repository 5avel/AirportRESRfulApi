namespace AirportRESRfulApi.Shared.DTO
{
    public class TicketDTO : BaseDTO
    {
        public decimal Price { set; get; }
        public string FlightNumber { set; get; }
        public int PlaseNumber { set; get; }
        public bool IsSold { set; get; }
    }
}