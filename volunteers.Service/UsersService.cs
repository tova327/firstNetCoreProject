using Volunteers.Core.entities;
using Volunteers.Core.InterfaceService;
using Volunteers.Core.InterfaseRepository;

namespace volunteers.Service
{
    public class UsersService:IGenericService<UserEntity>
    {
        IGenericRepository<UserEntity> _actions;
        public UsersService(IGenericRepository<UserEntity> actions)
        {
            _actions= actions;
        }
        public List<UserEntity> GetAll()
        {
            return _actions.GetAll();
        }
        public UserEntity GetById(int id)
        {
            return _actions.GetById(id);
        }
        public bool Delete(int id)
        {
            return _actions.Delete(id);
        }
        public bool Add(UserEntity entity)
        {
            return _actions.Add(entity);
        }
        public bool Update(int id,UserEntity entity)
        {
            return (_actions.Update(id,entity));
        }
    }
}