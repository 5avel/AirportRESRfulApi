using System;
namespace Shared.DTO
{
    public class Plane : BaseDTO
    {
        public string Name { set; get; }
        public PlaneType Type { set; get; }
        public DateTime ReleaseDate { set; get; }
    }
}
