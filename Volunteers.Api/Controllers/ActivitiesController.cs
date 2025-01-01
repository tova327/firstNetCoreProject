using Microsoft.AspNetCore.Mvc;
using Volunteers.Core.entities;
using Volunteers.Core.InterfaceService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Volunteers.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        IGenericService<ActivityEntity> activityService;
        public ActivitiesController(IGenericService<ActivityEntity> activityService)
        {
            this.activityService = activityService;
        }

        // GET: api/<ActivitiesController>
        [HttpGet]
        public ActionResult<IEnumerable<ActivityEntity>> Get()
        {
            return activityService.GetAll();
        }

        // GET api/<ActivitiesController>/5
        [HttpGet("{id}")]
        public ActionResult<ActivityEntity> Get(int id)
        {
            return activityService.GetById(id);
        }

        // POST api/<ActivitiesController>
        [HttpPost]
        public ActionResult<bool> AddActivity([FromBody] ActivityEntity value)
        {
            return activityService.Add(value);
        }

        // PUT api/<ActivitiesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateById(int id, [FromBody] ActivityEntity value)
        {
            return activityService.Update(id, value);
        }

        // DELETE api/<ActivitiesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return activityService.Delete(id);
        }
    }
}
