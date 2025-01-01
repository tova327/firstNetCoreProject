using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volunteers.Core.entities
{
    public enum ESize { Global, WideCountry, ThinCountry, City }

    public class OrgEntity
    {
        public int Id { get; private set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string FieldOfActivity { get; set; }
        public int NumberOfVolunteers { get; set; }
        public string Color { get; set; }
        public string Conditions { get; set; }

        public ESize Size { get; set; }
        public string HeadAdress { get; set; }
        public int ManagerId { get; set; }
        public string PhoneToContact { get; set; }
        public string OrgEmail { get; set; }
        public List<ActivityEntity> Activities { get; set; }
        public OrgEntity(int id, string tz, string name, string fieldOfActivity, int numberOfVolunteers, string color, string conditions, ESize size, string headAdress, int managerId, string phoneToContact, string orgEmail)
        {
            Id = id;
            Tz = tz;
            Name = name;
            FieldOfActivity = fieldOfActivity;
            NumberOfVolunteers = numberOfVolunteers;
            Color = color;
            Conditions = conditions;
            Size = size;
            HeadAdress = headAdress;
            ManagerId = managerId;
            PhoneToContact = phoneToContact;
            OrgEmail = orgEmail;
        }
    }
}
