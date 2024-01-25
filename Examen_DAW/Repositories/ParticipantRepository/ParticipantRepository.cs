using Examen.Data;
using Examen_DAW.Models;
using Examen_DAW.Repositories.EventRepository;

namespace Examen_DAW.Repositories.ParticipantRepository
{
    public class ParticipantRepository : IParticipantRepository
    {
        private readonly ApplicationDbContext _context;

        public ParticipantRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Participant> GetParticipants()
        {
            return _context.Participants.ToList();
        }


        public void AddParticipant(ParticipantDTO participantDto)
        {
            var newParticipant = new Participant
            {
                Id = participantDto.Id,
                Name = participantDto.Name,
                Email = participantDto.Email,
            };

            _context.Participants.Add(newParticipant);
            _context.SaveChanges();
        }

        public void UpdateParticipant(int id, ParticipantUpdateDTO participantUpdateDto)
        {
            var participantToUpdate = _context.Participants.Find(id);
            if (participantToUpdate == null)
            {
                throw new KeyNotFoundException("Participant not found");
            }

            participantToUpdate.Email = participantUpdateDto.Email;

            _context.SaveChanges();
        }

        public void DeleteParticipant(int id)
        {
            var participantToDelete = _context.Participants.Find(id);
            if (participantToDelete != null)
            {
                _context.Participants.Remove(participantToDelete);
                _context.SaveChanges();
            }
        }

       
    }
}
