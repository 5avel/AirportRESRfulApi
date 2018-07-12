﻿using AirportRESRfulApi.DAL;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System.Collections.Generic;

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
