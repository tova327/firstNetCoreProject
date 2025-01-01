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
    public class ActivityRepository:IGenericRepository<ActivityEntity>
    {
        readonly DataContext _dataContext; 
        public ActivityRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public List<ActivityEntity> GetAll()
        {
            return _dataContext.Activities.ToList();
        }
        public ActivityEntity GetById(int id)
        {
            int index = _dataContext.Activities.ToList().FindIndex(a => a.Id == id);
            if (index == -1)
                return null;
            return _dataContext.Activities.ToList()[index];
        }

        public bool ValidActivity(ActivityEntity activity)
        {
            if (activity == null || activity.Name == null || activity.NeededVolunteers <= 0) return false;
            if (_dataContext.Users.ToList().FindIndex(u => u.Id == activity.ManagerId) == -1) return false;
            if (_dataContext.Orgs.ToList().FindIndex(o => o.Id == activity.OrgId) == -1) return false;
            return true;
        }

        public bool Add(ActivityEntity activity)
        {
            //if (activity == null) return false; --אין צורך לבדוק כי הפונקציה מופעלת רק אם התנאי לא מתקיים
            if(!ValidActivity(activity)) return false;
            if (_dataContext.Activities.ToList().FindIndex(a => a.Id == activity.Id) != -1) return false;
            _dataContext.Activities.Add(activity);
            return _dataContext.saveData();
            
        }

        public bool Delete(int id)
        {
            int index = _dataContext.Activities.ToList().FindIndex(a => a.Id == id);
            if (index == -1) return false;
            _dataContext.Activities.ToList().RemoveAt(index);
            return _dataContext.saveData();
        }

        public bool Update(int id, ActivityEntity activity)
        {
            //if(activity== null) return false; --נשלח אחרי שעבר בדיקת תקינות
            if (!ValidActivity(activity)) return false;
            int index = _dataContext.Activities.ToList().FindIndex(a => a.Id == id);
            if (index == -1) return false;

            _dataContext.Activities.ToList()[index].Adress = activity.Adress;
            _dataContext.Activities.ToList()[index].Town = activity.Town;
            _dataContext.Activities.ToList()[index].Conditions = activity.Conditions;
            _dataContext.Activities.ToList()[index].ExistVolunteers = activity.ExistVolunteers;
            _dataContext.Activities.ToList()[index].Date = activity.Date;
            _dataContext.Activities.ToList()[index].Name = activity.Name;
            _dataContext.Activities.ToList()[index].ManagerId = activity.ManagerId;
            _dataContext.Activities.ToList()[index].NeededVolunteers = activity.NeededVolunteers;
            _dataContext.Activities.ToList()[index].OrgId = activity.OrgId;
            return _dataContext.saveData();
        }

    }
}
