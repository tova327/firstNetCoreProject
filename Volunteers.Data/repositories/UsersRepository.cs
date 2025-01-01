using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volunteers.Core.entities;
using Volunteers.Core.InterfaseRepository;

namespace Volunteers.Data.repositories
{
    
    public class UsersRepository:IGenericRepository<UserEntity>
    {
        readonly DataContext _dataContext;
        public UsersRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<UserEntity> GetAll()
        {

            return _dataContext.Users.ToList();
        }
        public UserEntity GetById(int id)
        {
            List<UserEntity> users = _dataContext.Users.ToList();
            int index = users.FindIndex(u => u.Id == id);
            if (index == -1)
                return null;
            return users[index];
        }

        public bool ValidUser(UserEntity u)
        {
            if (u == null) return false;
            foreach (char dig in u.Phone)
            {
                if (dig > '9' || dig < '0')
                    return false;
            }
            return true;

        }
        public bool Add(UserEntity user)
        {
            if(!ValidUser(user)) return false;
            DbSet<UserEntity> users = _dataContext.Users;
            if (users.ToList().FindIndex(u => u.Tz.Equals(user.Tz)) != -1) return false;
            users.Add(user);
            return _dataContext.saveData();
        }
        public bool Update(int id, UserEntity user)
        {
            if (!ValidUser(user)) return false;

            UserEntity? u = _dataContext.Users.ToList().FirstOrDefault(item => item.Id == id);    //.Find(item => item.Id == id);

            if (u == null)
                return false;
            u.Sex = user.Sex;
            u.Language = user.Language;
            u.Email = user.Email;
            u.Name = user.Name;
            u.Type = user.Type;
            u.BirthDate = user.BirthDate;
            u.LovedBranch = user.LovedBranch;
            u.Permissions = user.Permissions;
            u.Phone = user.Phone;
            u.Pin = user.Pin;
            u.Tz = user.Tz;
            return _dataContext.saveData();

        }
        public bool Delete(int id)
        {

            UserEntity? u = _dataContext.Users.ToList().FirstOrDefault(item => item.Id == id);    //.Find(item => item.Id == id);

            if (u == null)
                return false;
            _dataContext.Users.Remove(u);
            return _dataContext.saveData();
        }

    }
}
