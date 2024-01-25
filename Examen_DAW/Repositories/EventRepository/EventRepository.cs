using Examen.Data;
using Examen_DAW.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Examen_DAW.Repositories.EventRepository
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Event> GetEvents()
        {
            return _context.Events.Include(e => e.Participants).ToList();
        }

        public void AddEvent(EventDTO eventDto)
        {
            var newEvent = new Event
            {
                Name = eventDto.Name,
                Description = eventDto.Description,
                Date = eventDto.Date,
                Location = eventDto.Location
            };

            _context.Events.Add(newEvent);
            _context.SaveChanges();
        }

        public void UpdateEvents(int id, EventUpdateDTO eventUpdateDto)
        {
            var eventToUpdate = _context.Events.Find(id);
            if (eventToUpdate == null)
            {
                throw new KeyNotFoundException("Event not found");
            }

            eventToUpdate.Name = eventUpdateDto.Name;
            eventToUpdate.Description = eventUpdateDto.Description;
            eventToUpdate.Location = eventUpdateDto.Location;

            _context.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            var eventToDelete = _context.Events.Find(id);
            if (eventToDelete != null)
            {
                _context.Events.Remove(eventToDelete);
                _context.SaveChanges();
            }
        }
    }
}
