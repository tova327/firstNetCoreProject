using Microsoft.AspNetCore.Mvc;
using Volunteers.Core.entities;
using Volunteers.Core.InterfaceService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Volunteers.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerInActivityController : ControllerBase
    {
        IGenericService<VolunteerInActivityEntity> service;

        public VolunteerInActivityController(IGenericService<VolunteerInActivityEntity> service)
        {
            this.service = service;
        }


        // GET: api/<VolunteerInActivityController>
        [HttpGet]
        public ActionResult<IEnumerable<VolunteerInActivityEntity>> GetAll()
        {
            return service.GetAll();
        }

        // GET api/<VolunteerInActivityController>/5
        [HttpGet("{id}")]
        public ActionResult<VolunteerInActivityEntity> GetById(int id)
        {
            return service.GetById(id); 
        }

        // POST api/<VolunteerInActivityController>
        [HttpPost]
        public ActionResult<bool> Add([FromBody] VolunteerInActivityEntity value)
        {
            return service.Add(value);
        }

        // PUT api/<VolunteerInActivityController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Update(int id, [FromBody] VolunteerInActivityEntity value)
        {
            return service.Update(id, value);
        }

        // DELETE api/<VolunteerInActivityController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
