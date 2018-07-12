using System;
using System.Collections.Generic;
using System.Text;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;

namespace AirportRESRfulApi.BLL.Services
{
    public class TicketService : ITicketService
    {
        private IRepository<Ticket> _repository;
        private IMapper _mapper;
        public TicketService(IRepository<Ticket> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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

        

        public TicketDto Make(TicketDto entity)
        {
            var makedEntity = _mapper.Map<TicketDto, Ticket>(entity);
            return _mapper.Map<Ticket, TicketDto>(_repository.Create(makedEntity));
        }

        public TicketDto Update(TicketDto entity)
        {
            var updatedEntity = _mapper.Map<TicketDto, Ticket>(entity);
            return _mapper.Map<Ticket, TicketDto>(_repository.Update(updatedEntity));
        }



    }
}
