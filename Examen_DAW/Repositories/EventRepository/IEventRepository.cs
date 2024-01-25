using Examen_DAW.Models;

namespace Examen_DAW.Repositories.EventRepository
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetEvents();
        void AddEvent(EventDTO eventDto);
        void UpdateEvents(int id, EventUpdateDTO eventUpdateDto);
        void DeleteEvent(int id);
    }
}
