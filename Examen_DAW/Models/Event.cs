﻿namespace Examen_DAW.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public List<EventParticipant> EventParticipants { get; set; }
        public ICollection<Participant> Participants { get; set; }

    }
}
