using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volunteers.Core.entities
{
    public enum ESex { Male, Female };
    [Flags]
    public enum EPermissions { ChangeUserData = 1, ChangeOrgData = 2 }

    public enum ELanguage { English, Hebrew }
    public enum EType { Worker, Volunteer, OrgManager }
    public class UserEntity
    {

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Tz { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public ESex Sex { get; set; }
        public string? LovedBranch { get; set; }
        public EPermissions Permissions { get; set; }
        public ELanguage Language { get; set; }
        public EType Type { get; set; }
        public string Pin { get; set; }

        public UserEntity(int id, string name, string tz, string email, string phone, DateTime birthDate, ESex sex, string? lovedBranch, EPermissions permissions, ELanguage language, EType type, string pin)
        {
            Id = id;
            Name = name;
            Tz = tz;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
            Sex = sex;
            LovedBranch = lovedBranch;
            Permissions = permissions;
            Language = language;
            Type = type;
            Pin = pin;
        }
    }
}
