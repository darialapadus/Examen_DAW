using Examen_DAW.Models;

namespace Examen_DAW.Repositories.ParticipantRepository
{
    public interface IParticipantRepository
    {
        IEnumerable<Participant> GetParticipants();
        void AddParticipant(ParticipantDTO participantDto);
        void UpdateParticipant(int id, ParticipantUpdateDTO updatedParticipant);
        void DeleteParticipant(int id);
    }
}
