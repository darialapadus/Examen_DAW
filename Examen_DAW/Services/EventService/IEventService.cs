using Examen_DAW.Models;

namespace Examen_DAW.Services.EventService
{
    public interface IEventService
    {
        IEnumerable<EventDTO> GetEvents();
        void AddEvent(EventDTO eventDto);
        void UpdateEvents(int id, EventUpdateDTO updatedEvent);
        void DeleteEvent(int id);
    }
}
