using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volunteers.Core.InterfaseRepository
{
    public interface IGenericRepository<T>
    {


        public T GetById(int id);
        public List<T> GetAll();
        public bool Update(int id,T entity);
        public bool Delete(int id);
        public bool Add(T entity);
    }
}
