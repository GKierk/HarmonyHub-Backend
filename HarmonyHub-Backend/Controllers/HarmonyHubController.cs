using HarmonyHub_Backend.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HarmonyHub_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HarmonyHubController : ControllerBase
    {
        private MusicRecordRepository musicRecordRepository;

        public HarmonyHubController(MusicRecordRepository musicRecordRepository)
        {
            this.musicRecordRepository = musicRecordRepository;
        }

        // GET: api/<HarmonyHubController>
        [HttpGet]
        public IEnumerable<MusicRecord> Get()
        {
            return musicRecordRepository.Read(); 
        }

        // GET api/<HarmonyHubController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HarmonyHubController>
        [HttpPost]
        public void Post([FromBody] MusicRecord value)
        {
            musicRecordRepository.Create(value);
        }

        // PUT api/<HarmonyHubController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MusicRecord music)
        {
            musicRecordRepository.Update(id, music);
        }

        // DELETE api/<HarmonyHubController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            musicRecordRepository.Delete(id);
        }
    }
}
