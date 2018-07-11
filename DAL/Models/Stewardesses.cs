namespace DAL.Models
{
    using System;
    public class Stewardesses : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}