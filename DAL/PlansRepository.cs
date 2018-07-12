using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.DAL
{
    public class PlansRepository : IRepository<Plane>
    {
        private IAirportContext _airportContext;
        public PlansRepository(IAirportContext airportContext)
        {
            _airportContext = airportContext;
        }

        public Plane Create(Plane entity)
        {
            _airportContext.Plans.Add(entity);
            return entity;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.Plans.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.Plans.Remove(itemToRemove);
        }

        public bool Delete(Plane entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<Plane> Find(Func<Plane, bool> predicate)
        {
            return _airportContext.Plans?.Where(predicate);
        }

        public IEnumerable<Plane> GetAll()
        {
            return _airportContext.Plans;
        }

        public Plane GetById(int id)
        {
            return _airportContext.Plans?.FirstOrDefault(t => t.Id == id);
        }

        public Plane Update(Plane entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.Plans?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if (_airportContext.Plans.Remove(updatedEntity))
            {
                _airportContext.Plans.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
