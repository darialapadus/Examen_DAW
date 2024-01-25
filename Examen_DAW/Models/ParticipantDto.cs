namespace Examen_DAW.Models
{
    public class ParticipantDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ParticipantRole Role { get; set; }
        public List<EventParticipant> EventParticipants { get; set; }

    }

}
