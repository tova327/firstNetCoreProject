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
    public class ActivitiesService: IGenericService<ActivityEntity>
    {
        IGenericRepository<ActivityEntity> _activity;
        public ActivitiesService(IGenericRepository<ActivityEntity> act)
        {
            _activity= act;
        }

        public List<ActivityEntity> GetAll()
        {
            return _activity.GetAll();
        }

        public ActivityEntity GetById(int id)
        {
            return _activity.GetById(id);
        }
        public bool Delete(int id)
        {
            return _activity.Delete(id);
        }
        public bool Add(ActivityEntity entity)
        {
            
            return _activity.Add(entity);
        }
        public bool Update(int id ,ActivityEntity entity)
        {
            return (_activity.Update(id, entity));
        }


    }
}
