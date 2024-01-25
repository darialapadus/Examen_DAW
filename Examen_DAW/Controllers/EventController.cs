using Examen_DAW.Models;
using Examen_DAW.Services.EventService;
using Microsoft.AspNetCore.Mvc;

namespace Examen_DAW.Controllers
{
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        [Route("api/eventss")]
        public IActionResult GetEvents()
        {
            var events = _eventService.GetEvents();
            return Ok(events);
        }

        [HttpPost]
        [Route("api/eventsss")]
        public IActionResult AddEvent([FromBody] EventDTO eventDto)
        {
            _eventService.AddEvent(eventDto);
            return Ok();
        }

        
        [Route("api/events/{id}")]
        [HttpPut]
        public IActionResult UpdateEvent(int id, [FromBody] EventUpdateDTO updatedEvent)
        {
            _eventService.UpdateEvents(id, updatedEvent);
            return Ok();
        }

        [Route("api/eventsdelete/{id}")]
        [HttpDelete]
        public IActionResult DeleteEvent(int id)
        {
            _eventService.DeleteEvent(id);
            return Ok();
        }
    }
}
