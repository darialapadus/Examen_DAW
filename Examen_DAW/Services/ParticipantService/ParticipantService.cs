using Examen_DAW.Models;
using Examen_DAW.Repositories.ParticipantRepository;

namespace Examen_DAW.Services.ParticipantService
{
    public class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepository _participantRepository;

        public ParticipantService(IParticipantRepository participantRepository)
        {
            _participantRepository = participantRepository;
        }

        public IEnumerable<Participant> GetParticipants()
        {
            var participants = _participantRepository.GetParticipants();
            return participants.Select(p => new Participant
            {
                Id = p.Id,
                Name = p.Name,
                Email = p.Email
            }).ToList();
        }


        public void AddParticipant(ParticipantDTO participantDto)
        {
            _participantRepository.AddParticipant(participantDto);
        }

        public void UpdateParticipant(int id, ParticipantUpdateDTO updatedParticipant)
        {
            _participantRepository.UpdateParticipant(id, updatedParticipant);
        }


        public void DeleteParticipant(int id)
        {
            _participantRepository.DeleteParticipant(id);
        }
    }
}
