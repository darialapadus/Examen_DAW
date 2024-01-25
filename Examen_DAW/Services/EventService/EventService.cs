using Examen_DAW.Models;
using Examen_DAW.Repositories.EventRepository;

namespace Examen_DAW.Services.EventService
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public IEnumerable<EventDTO> GetEvents()
        {
            var events = _eventRepository.GetEvents();
            return events.Select(c => new EventDTO
            {
                Name = c.Name,
                Description = c.Description,
                Date = c.Date,
                Location = c.Location
            }).ToList();
        }

        public void AddEvent(EventDTO eventDto)
        {
            _eventRepository.AddEvent(eventDto);
        }

        public void UpdateEvents(int id, EventUpdateDTO updatedEvent)
        {
            _eventRepository.UpdateEvents(id, updatedEvent);
        }

        public void DeleteEvent(int id)
        {
            _eventRepository.DeleteEvent(id);
        }
    }
}

