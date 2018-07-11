﻿namespace AirportRESRfulApi.Shared.DTO
{
    using System;
    public class PlaneType : BaseDTO
    {
        public string Model { set; get; }
        public int Seats { set; get; }
        public int Capacity { set; get; }
        public int Range { set; get; }
        public TimeSpan ServiceLife { set; get; }
    }
}