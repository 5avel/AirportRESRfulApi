using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using System;

namespace AirportRESRfulApi.BLL.Services
{
    public class FlightsService : IFlightsService
    {
        private IRepository<Flight> _repository;
        private IMapper _mapper;

        public FlightsService(IRepository<Flight> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<FlightDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDto>>(entity);
        }

        public FlightDto GetByFlightNumberAndDate(string flightNumber, DateTime flightDate)
        {
            var entity = _repository.Find(f => f.FlightNumber == flightNumber & f.DepartureTime == flightDate).FirstOrDefault();
            return _mapper.Map<Flight, FlightDto>(entity);
        }

        public FlightDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Flight, FlightDto>(entity);
        }

        public FlightDto Make(FlightDto entity)
        {
            var makedEntity = _mapper.Map<FlightDto, Flight>(entity);
            return _mapper.Map<Flight, FlightDto>(_repository.Create(makedEntity));
        }

        public FlightDto Update(FlightDto entity)
        {
            var updatedEntity = _mapper.Map<FlightDto, Flight>(entity);
            return _mapper.Map<Flight, FlightDto>(_repository.Update(updatedEntity));
        }
    }
}
