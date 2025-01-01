using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volunteers.Core.entities;
using Volunteers.Core.InterfaseRepository;

namespace Volunteers.Data.repositories
{
    public class OrgRepository:IGenericRepository<OrgEntity>
    {
        readonly DataContext _dataContext;
        public OrgRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public List<OrgEntity> GetAll()
        {
            return _dataContext.Orgs.ToList();
        }
        public OrgEntity GetById(int id)
        {

            int index = _dataContext.Orgs.ToList().FindIndex(item => item.Id == id);
            if (index == -1)
                return null;
            return _dataContext.Orgs.ToList()[index];
        }

        public bool validOrg(OrgEntity org)
        {
            int index = _dataContext.Orgs.ToList().FindIndex(item => item.Id == org.ManagerId);
            if (index == -1)
                return false;
            foreach (var c in org.PhoneToContact)
            {
                if (c > '9' || c < '0')
                    return false;
            }
            return true;
        }

        public bool Add(OrgEntity org)
        {
            if(!validOrg(org)) return false;
            int index = _dataContext.Orgs.ToList().FindIndex(item => item.Id == org.Id);
            if (index != -1)
                return false;
            _dataContext.Orgs.Add(org);
            return _dataContext.saveData();

        }

        public bool Delete(int id)
        {
            OrgEntity? o = _dataContext.Orgs.ToList().FirstOrDefault(item => item.Id == id);    //.Find(item => item.Id == id);

            if (o == default(OrgEntity))
                return false;
            _dataContext.Orgs.Remove(o);     //.RemoveAt(index);
            return _dataContext.saveData();
        }

        public bool Update(int id, OrgEntity org)
        {
            if(!validOrg(org)) return false;
            OrgEntity? o = _dataContext.Orgs.ToList().FirstOrDefault(item => item.Id == id);    //.Find(item => item.Id == id);

            if (o == default(OrgEntity))
                return false;
            
            o.PhoneToContact = org.PhoneToContact;
            o.Size = org.Size;
            o.OrgEmail = org.OrgEmail;
            o.Name = org.Name;
            o.ManagerId = org.ManagerId;
            o.Color = org.Color;
            o.Conditions = org.Conditions;
            o.FieldOfActivity = org.FieldOfActivity;
            o.HeadAdress = org.HeadAdress;
            return _dataContext.saveData();
        }
    }
}
