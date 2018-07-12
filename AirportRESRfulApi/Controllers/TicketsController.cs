using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private ITicketsService _ticketSrvice;
        public TicketsController(ITicketsService ticketSrvice)
        {
            _ticketSrvice = ticketSrvice;
        }

        // GET api/Tickets
        [HttpGet]
        public ActionResult<IEnumerable<TicketDto>> Get()
        {
            return _ticketSrvice.Get().ToList();
        }

        // GET api/Tickets/2
        [HttpGet("{id}")]
        public ActionResult<TicketDto> Get(int id)
        {
            var ticket = _ticketSrvice.GetById(id);

            if (ticket == null) return NotFound();

            return _ticketSrvice.GetById(id);
        }

        // POST api/Tickets
        [HttpPost]
        public ActionResult<TicketDto> Post([FromBody] TicketDto ticket)
        {
            return _ticketSrvice.Make(ticket);
        }

        // PUT api/Tickets/2
        [HttpPut("{id}")]
        public TicketDto Put(int id, [FromBody] TicketDto ticket)
        {
            return _ticketSrvice.Update(ticket);
        }

        // DELETE api/Tickets/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_ticketSrvice.Delete(id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
