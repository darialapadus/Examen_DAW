namespace Examen_DAW.Models
{
    public enum ParticipantRole { Spectator, Organizer }

    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ParticipantRole Role { get; set; }

        public List<EventParticipant> EventParticipants { get; set; }
    }
}
