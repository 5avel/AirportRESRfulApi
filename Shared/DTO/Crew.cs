using System.Collections.Generic;

namespace Shared.DTO
{
    public class Crew : BaseDTO
    {
        public Pilot Pilot { set; get; }
        public List<Stewardesses> Stewardesses { set; get; }
    }
}