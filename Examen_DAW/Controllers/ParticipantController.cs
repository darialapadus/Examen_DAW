using Examen_DAW.Models;
using Examen_DAW.Services.EventService;
using Examen_DAW.Services.ParticipantService;
using Microsoft.AspNetCore.Mvc;

namespace Examen_DAW.Controllers
{
    public class ParticipantController : ControllerBase
    {
        private readonly IParticipantService _participantService;

        public ParticipantController(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        [HttpGet]
        [Route("api/participantss")]
        public IActionResult GetParticipants()
        {
            var participants = _participantService.GetParticipants();
            return Ok(participants);
        }

        [HttpPost]
        [Route("api/participantsss")]
        public IActionResult AddParticipant([FromBody] ParticipantDTO participantDto)
        {
            _participantService.AddParticipant(participantDto);
            return Ok();
        }
        [Route("api/participants/{id}")]
        [HttpPut]
        public IActionResult UpdateParticipant(int id, [FromBody] ParticipantUpdateDTO updatedParticipant)
        {
            _participantService.UpdateParticipant(id, updatedParticipant);
            return Ok();
        }

        [Route("api/participantsdelete/{id}")]
        [HttpDelete]
        public IActionResult DeleteParticipant(int id)
        {
            _participantService.DeleteParticipant(id);
            return Ok();
        }
    }
}
