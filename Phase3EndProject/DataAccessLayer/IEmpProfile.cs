using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IEmpProfile<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetByCode(int code);

        void Insert(T entity);

        void Update(T entity);

        void Delete(int code);

        void Save();

    }
}
