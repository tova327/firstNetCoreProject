using Microsoft.AspNetCore.Mvc;
using Volunteers.Core.entities;
using Volunteers.Core.InterfaceService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Volunteers.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IGenericService<UserEntity> _service;
        public UsersController(IGenericService<UserEntity> service)
        { 
            _service = service;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<IEnumerable<UserEntity>> GetAll()
        {
            return _service.GetAll();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<UserEntity> GetById(int id)
        {
            return _service.GetById(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] UserEntity value)
        {
            return _service.Add(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Update(int id, [FromBody] UserEntity value)
        {
            return _service.Update(id, value);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
