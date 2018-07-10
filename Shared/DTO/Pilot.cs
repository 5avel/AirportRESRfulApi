using System;
namespace Shared.DTO
{
    public class Pilot : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { set; get; }
    }
}