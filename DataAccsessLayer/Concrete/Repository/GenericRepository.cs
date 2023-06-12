using DataAccsessLayer.Abstract;
using DataAccsessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T t)
        {
            using var context = new ArgicultureContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)//aşağıdaki işlem id bulma işlemidir.
        {
            using var context = new ArgicultureContext();
            return context.Set<T>().Find(id);

        }

        public List<T> GetListAll()
        {
            using var context = new ArgicultureContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new ArgicultureContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new ArgicultureContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
