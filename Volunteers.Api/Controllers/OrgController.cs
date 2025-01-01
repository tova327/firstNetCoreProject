using Microsoft.AspNetCore.Mvc;
using Volunteers.Core.entities;
using Volunteers.Core.InterfaceService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Volunteers.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrgController : ControllerBase
    {
        IGenericService<OrgEntity> _service;
        public OrgController(IGenericService<OrgEntity> service)
        {
            _service = service;
        }

        // GET: api/<OrgController>
        [HttpGet]
        public ActionResult<IEnumerable<OrgEntity>> Get()
        {
            return _service.GetAll();
        }

        // GET api/<OrgController>/5
        [HttpGet("{id}")]
        public ActionResult<OrgEntity> GetById(int id)
        {
            return _service.GetById(id);
        }

        // POST api/<OrgController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] OrgEntity value)
        {
            return _service.Add(value);
        }

        // PUT api/<OrgController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateAllFields(int id, [FromBody] OrgEntity value)
        {
            return _service.Update(id, value);
        }

        // DELETE api/<OrgController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
