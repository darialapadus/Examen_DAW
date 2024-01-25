using Examen_DAW.Models;

namespace Examen_DAW.Services.ParticipantService
{
    public interface IParticipantService
    {
        IEnumerable<Participant> GetParticipants();
        void AddParticipant(ParticipantDTO participantDto);
        void UpdateParticipant(int id, ParticipantUpdateDTO updatedParticipant);
        void DeleteParticipant(int id);
    }
}
