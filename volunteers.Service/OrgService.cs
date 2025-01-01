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
    public class OrgService:IGenericService<OrgEntity>
    {
        IGenericRepository<OrgEntity> _actions;
        public OrgService(IGenericRepository<OrgEntity> actions) 
        { 
            _actions= actions;
        }
        public List<OrgEntity> GetAll()
        {
            return _actions.GetAll();
        }
        public OrgEntity GetById(int id)
        {
            return _actions.GetById(id);
        }
        public bool Delete(int id)
        {
            return _actions.Delete(id);
        }
        public bool Update(int id,OrgEntity org)
        {
            return _actions.Update(id, org);
        }
        public bool Add(OrgEntity org)
        {
            return _actions.Add(org);
        }
    }
}
