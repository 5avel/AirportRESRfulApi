﻿using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.BLL.Validations;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Services
{
    public class TicketsService : ITicketsService
    {
        private IRepository<Ticket> _repository;
        private IFlightsService _flightsService;
        private IMapper _mapper;
        public TicketsService(IRepository<Ticket> repository, IMapper mapper, IFlightsService flightsService)
        {
            _repository = repository;
            _mapper = mapper;
            _flightsService = flightsService;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<TicketDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDto>>(entity);
        }


        public TicketDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Ticket, TicketDto>(entity);
        }

        public IEnumerable<TicketDto> GetNotSoldSByFlightIdAndDate(string flightNumber, DateTime flightDate)
        {
            FlightDto flight = _flightsService.GetByFlightNumberAndDate(flightNumber, flightDate);
            var entity = _repository.Find(t => t.FlightId == flight.Id);
            return _mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDto>>(entity);
        }

        public TicketDto BayById(int id)
        {
            var entity = _repository.GetById(id);

            if (entity == null) return null;

            if (entity.IsSold == true) return null; // Уже был продан

            entity.IsSold = true;
            var result = _repository.Update(entity);

            if (result == null) return null;

            return _mapper.Map<Ticket, TicketDto>(result);
        }

        public TicketDto ReturnById(int id)
        {
            var entity = _repository.GetById(id);

            if (entity == null) return null;

            if (entity.IsSold == false) return null;  // Уже был возвращен

            entity.IsSold = false;
            var result = _repository.Update(entity);

            if (result == null) return null;

            return _mapper.Map<Ticket, TicketDto>(result);
        }


        public TicketDto Make(TicketDto entity)
        {
            if (new TicketValidator().Validate(entity).IsValid != true) return null;

            var makedEntity = _mapper.Map<TicketDto, Ticket>(entity);
            return _mapper.Map<Ticket, TicketDto>(_repository.Create(makedEntity));
        }

        public TicketDto Update(TicketDto entity)
        {
            if (new TicketValidator().Validate(entity).IsValid != true) return null;

            var updatedEntity = _mapper.Map<TicketDto, Ticket>(entity);
            return _mapper.Map<Ticket, TicketDto>(_repository.Update(updatedEntity));
        }



    }
}