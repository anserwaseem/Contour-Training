using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    internal interface IGenericRepository<T>
    {
        List<T> Get();
        void Add(T entity);
        void Delete(T entity);

        //void Update(T entity);
    }
}
