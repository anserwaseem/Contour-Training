using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    internal abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        List<T> list = new List<T>();
        public List<T> Get()
        {
            return list;
        }
        public void Add(T entity)
        {
            list.Add(entity);
        }
        public void Delete(T entity)
        {
            list.Remove(entity);
        } 
        //public void Update(T entity)
        //{
            
        //}
    }
}
