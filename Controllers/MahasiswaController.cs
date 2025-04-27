using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul10_103022330091.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        Mahasiswa[] listMahasiswa = { new Mahasiswa("Nicholas Putra Irawan", "103022330091"), new Mahasiswa("LeBron James", "0001232130"), new Mahasiswa("Stephen Curry", "12312387912") };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa.ElementAt(id);
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
