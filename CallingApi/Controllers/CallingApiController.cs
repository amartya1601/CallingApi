using CallingApi.Interface;
using CallingApi.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CallingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CallingApiController : ControllerBase
    {
        private readonly IStudentInterface _studserv;

        public CallingApiController(IStudentInterface studserv)
        {
            _studserv = studserv;
        }

        // GET: api/<CallingApiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CallingApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CallingApiController>
        [HttpPost]
        public async Task<IActionResult> Post(StudentDetailsRequest sd)
        {
          var res= await _studserv.AddStudent(sd);
            return Ok(res);
        }

        // PUT api/<CallingApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CallingApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
