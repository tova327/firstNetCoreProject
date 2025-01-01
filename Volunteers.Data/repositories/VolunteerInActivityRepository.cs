using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volunteers.Core.entities;
using Volunteers.Core.InterfaseRepository;

namespace Volunteers.Data.repositories
{
    
    public class VolunteerInActivityRepository:IGenericRepository<VolunteerInActivityEntity>
    {
        readonly DataContext _dataContext;
        public VolunteerInActivityRepository(DataContext d)
        {
            _dataContext= d;
        }

        public List<VolunteerInActivityEntity> GetAll()
        {
            return _dataContext.VolunteerInActivities.ToList();
        }
        public VolunteerInActivityEntity? GetById(int id)
        {
            return _dataContext.VolunteerInActivities.ToList().FirstOrDefault(x => x.Id == id);
        }

        public bool ValidItem(VolunteerInActivityEntity item)
        {
            if (item == null) return false;
            if (!_dataContext.Users.Any(u => u.Id == item.VolunteerId)) return false;
            if (!_dataContext.Activities.Any(u => u.Id == item.ActivityId)) return false;
            return true;
        }

        public bool Add(VolunteerInActivityEntity vo)
        {
            if (!ValidItem(vo)) return false;

            List<OrgEntity> o = _dataContext.Orgs.ToList();
            List<ActivityEntity> a = _dataContext.Activities.ToList();
            if (_dataContext.VolunteerInActivities.Any(v => v.ActivityId == vo.ActivityId && v.VolunteerId == vo.VolunteerId)) return false;
            int activityId = vo.ActivityId;
            a[a.FindIndex(ac => ac.Id == activityId)].ExistVolunteers++;
            int orgId = a.Find(a => a.Id == activityId).OrgId;
            o[o.FindIndex(or => or.Id == orgId)].NumberOfVolunteers++;
            _dataContext.VolunteerInActivities.Add(vo);
            return _dataContext.saveData();

        }

        public bool Update(int id, VolunteerInActivityEntity vo)
        {
            if (!ValidItem(vo)) return false;
            VolunteerInActivityEntity? a = _dataContext.VolunteerInActivities.ToList().FirstOrDefault(a => a.Id == id);
            if (a == null) return false;
            a.LogIn = vo.LogIn;
            a.Experience = vo.Experience;
            a.ManagerSatisfaction = vo.ManagerSatisfaction;
            a.BringMe = vo.BringMe;
            a.ContactEmail = vo.ContactEmail;
            a.MonthParticipate = vo.MonthParticipate;
            a.VolunteerSatisfaction = vo.VolunteerSatisfaction;
            return _dataContext.saveData();
        }

        public bool Delete(int id)
        {
            VolunteerInActivityEntity? a = _dataContext.VolunteerInActivities.ToList().FirstOrDefault(a => a.Id == id);
            if (a == null) return false;
            _dataContext.VolunteerInActivities.Remove(a);
            return _dataContext.saveData();

        }
    }
}
