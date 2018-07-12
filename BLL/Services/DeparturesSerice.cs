﻿using AirportRESRfulApi.DAL;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Services
{
    public class DeparturesSerice : IDeparturesService
    {

        private IRepository<Departure> _repository;
        private IMapper _mapper;

        public DeparturesSerice(IRepository<Departure> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<DepartureDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<Departure>, IEnumerable<DepartureDto>>(entity);
        }

        public DepartureDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Departure, DepartureDto>(entity);
        }

        public DepartureDto Make(DepartureDto entity)
        {
            var makedEntity = _mapper.Map<DepartureDto, Departure>(entity);
            return _mapper.Map<Departure, DepartureDto>(_repository.Create(makedEntity));
        }

        public DepartureDto Update(DepartureDto entity)
        {
            var updatedEntity = _mapper.Map<DepartureDto, Departure>(entity);
            return _mapper.Map<Departure, DepartureDto>(_repository.Update(updatedEntity));
        }
    }
}
