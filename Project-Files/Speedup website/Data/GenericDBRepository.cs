using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Linq;

namespace Speedup_website.Data
{
    public class GenericDBRepository<T> : IRepository<T> where T : class
    {
        SpeedupWebsiteDBContext context;
        DbSet<T> dbSet;

        public GenericDBRepository(SpeedupWebsiteDBContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            T? exists = dbSet.Find(id);

            if (exists != null)
                context.Remove(exists);

            context.SaveChanges();
        }

        public T Find(int id) => dbSet.Find(id);

        public IList<T> List() => dbSet.ToList();

        public List<T> Search(string term, PropertyInfo[] properties)
        {
            List<T> list = dbSet.ToList();
            List<T> sItems = new List<T>();

            term = term.Trim().ToLower();

            foreach (var item in list)
            {
                foreach (PropertyInfo property in properties)
                {
                    if (typeof(T)
                        .GetProperty(property.Name)
                        .GetValue(item, null)
                        .ToString()
                        .ToLower()
                        .Contains(term)
                        )
                    {
                        sItems.Add(item);
                        break;
                    }
                }
            }

            if (sItems.Count == 0)
                return new List<T>();

            sItems.Sort();
            return sItems;
        }

        public void Update(int id, T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}