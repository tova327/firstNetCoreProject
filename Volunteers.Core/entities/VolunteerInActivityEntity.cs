using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volunteers.Core.entities
{
    public class VolunteerInActivityEntity
    {
        public int Id { get; private set; }

        public int VolunteerId { get; set; }
        public int ActivityId { get; set; }
        public int MonthParticipate { get; set; }
        public int ManagerSatisfaction { get; set; }
        public int VolunteerSatisfaction { get; set; }
        public DateTime LogIn { get; set; }
        public string Experience { get; set; }
        public string BringMe { get; set; }
        public string ContactEmail { get; set; }

        public VolunteerInActivityEntity(int id, int volunteerId, int activityId, int monthParticipate, int managerSatisfaction, int volunteerSatisfaction, DateTime logIn, string experience, string bringMe, string contactEmail)
        {
            Id = id;

            VolunteerId = volunteerId;
            ActivityId = activityId;
            MonthParticipate = monthParticipate;
            ManagerSatisfaction = managerSatisfaction;
            VolunteerSatisfaction = volunteerSatisfaction;
            LogIn = logIn;
            Experience = experience;
            BringMe = bringMe;
            ContactEmail = contactEmail;
        }
    }
}
