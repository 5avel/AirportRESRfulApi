using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportRESRfulApi.DAL.Models;

namespace AirportRESRfulApi.DAL
{
    public class TicketsRepository : IRepository<Ticket>
    {
        private IAirportContext _airportContext;
        public TicketsRepository(IAirportContext airportContext)
        {
            _airportContext = airportContext;
        }
        public Ticket Create(Ticket entity)
        {
            _airportContext.Tickets.Add(entity);
            return entity;
        }

        public bool Delete(int id)
        {
            var ticketToRemove = _airportContext.Tickets.FirstOrDefault(t => t.Id == id);
            if (ticketToRemove == null) return false;
            return _airportContext.Tickets.Remove(ticketToRemove);
        }

        public bool Delete(Ticket entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<Ticket> Find(Func<Ticket, bool> predicate)
        {
            return _airportContext.Tickets?.Where(predicate);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _airportContext.Tickets;
        }

        public Ticket GetById(int id)
        {
            return _airportContext.Tickets?.FirstOrDefault(t => t.Id == id);
        }

        public Ticket Update(Ticket entity)
        {
            var updatedEntity = _airportContext.Tickets?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;
            updatedEntity = entity;
            return updatedEntity;
        }
    }
}
