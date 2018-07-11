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


        public TicketDTO GetTicketById(int id)
        {
            var ticket = _ticketRepository.GetById(id);
            
            return _mapper.Map<Ticket, TicketDTO>(ticket);
        }

        public IEnumerable<TicketDTO> GetTickets()
        {
            var tickets = _ticketRepository.GetAll();
            return _mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDTO>>(tickets);
        }

        public TicketDTO MakeTicket(TicketDTO ticket)
        {
            var makedTicket = _mapper.Map<TicketDTO, Ticket>(ticket);
            return _mapper.Map<Ticket, TicketDTO>(_ticketRepository.Create(makedTicket));
        }

        public TicketDTO UpdateTicket(TicketDTO ticket)
        {
            var updatedTicket = _mapper.Map<TicketDTO, Ticket>(ticket);
            return _mapper.Map<Ticket, TicketDTO>(_ticketRepository.Update(updatedTicket));
        }

        public bool DeleteTicket(int id)
        {
            return _ticketRepository.Delete(id);
        }

    }
}
