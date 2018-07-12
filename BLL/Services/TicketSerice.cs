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
        private IRepository<Ticket> _ticketRepository;
        private IMapper _mapper;
        public TicketService(IRepository<Ticket> ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }


        public TicketDto GetTicketById(int id)
        {
            var ticket = _ticketRepository.GetById(id);
            
            return _mapper.Map<Ticket, TicketDto>(ticket);
        }

        public IEnumerable<TicketDto> GetTickets()
        {
            var tickets = _ticketRepository.GetAll();
            return _mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDto>>(tickets);
        }

        public TicketDto MakeTicket(TicketDto ticket)
        {
            var makedTicket = _mapper.Map<TicketDto, Ticket>(ticket);
            return _mapper.Map<Ticket, TicketDto>(_ticketRepository.Create(makedTicket));
        }

        public TicketDto UpdateTicket(TicketDto ticket)
        {
            var updatedTicket = _mapper.Map<TicketDto, Ticket>(ticket);
            return _mapper.Map<Ticket, TicketDto>(_ticketRepository.Update(updatedTicket));
        }

        public bool DeleteTicket(int id)
        {
            return _ticketRepository.Delete(id);
        }

    }
}
