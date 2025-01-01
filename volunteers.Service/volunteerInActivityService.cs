using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volunteers.Core.entities;
using Volunteers.Core.InterfaceService;
using Volunteers.Core.InterfaseRepository;

namespace volunteers.Service
{
    public class volunteerInActivityService :IGenericService<VolunteerInActivityEntity>
    {
        IGenericRepository<VolunteerInActivityEntity> _actions;
        public volunteerInActivityService(IGenericRepository<VolunteerInActivityEntity> actions)
        {
            _actions= actions;
        }
        public List<VolunteerInActivityEntity> GetAll()
        {
            return _actions.GetAll();
        }
        public VolunteerInActivityEntity GetById(int id)
        {
            return _actions.GetById(id);
        }
        public bool Delete(int id)
        {
            return _actions.Delete(id);
        }
        public bool Add(VolunteerInActivityEntity entity)
        {
            return _actions.Add(entity);
        }
        public bool Update(int id,VolunteerInActivityEntity entity)
        {
            return (_actions.Update(id, entity));
        }
    }
}
