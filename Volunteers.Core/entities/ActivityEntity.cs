using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volunteers.Core.entities
{
    public class ActivityEntity
    {
        public int Id { get; private set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }

        public string Town { get; set; }
        public string Adress { get; set; }
        public string Conditions { get; set; }

        public int NeededVolunteers { get; set; }
        public int ExistVolunteers { get; set; }

        public int ManagerId { get; set; }
        //[ForeignKey("ManagerId")]
        //public UserEntity Manager { get; set; } 

        //public List<VolunteerInActivityEntity> VolunteerInActivity { get; set; }    

        public int OrgId { get; set; }
        //[ForeignKey("OrgId")]
        //public OrgEntity Org { get; set; }  
        public ActivityEntity(int id, string name, DateTime date, string town, string adress, string conditions, int neededVolunteers, int existVolunteers, int managerId, int orgId)
        {
            Id = id;
            Name = name;
            Date = date;
            Town = town;
            Adress = adress;
            Conditions = conditions;
            NeededVolunteers = neededVolunteers;
            ExistVolunteers = existVolunteers;
            ManagerId = managerId;
            OrgId = orgId;
        }
    }
}
