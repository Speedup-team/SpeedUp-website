using System.Linq;
using System.Reflection;

namespace Speedup_website.Data
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        public List<T> Entitys;

        Type entityType;
        PropertyInfo idProperty;
        public GenericRepository()
        {
            entityType = typeof(T);
            idProperty = entityType.GetProperty("id");
        }

        public IList<T> List() => Entitys;

        public T Find(int id) => Entitys.SingleOrDefault(t => (int)idProperty.GetValue(t) == id);

        public void Add(T entity)
        {
            if (entity is not null)
            {
                idProperty.SetValue(entity, Entitys.Max(t => (int)idProperty.GetValue(t)) + 1);

                Entitys.Add(entity);
            }
        }

        public void Update(int id, T entity)
        {
            T t = Find(id);

            if (t != null)
            {
                PropertyInfo[] properties = typeof(T).GetProperties();

                for (int i = 0; i <= properties.Length - 1; i++)
                {
                    entityType
                        .GetProperty(properties[i].Name)
                        .SetValue(entity, properties[i], null);
                }
            }
        }

        public void Delete(int id) => Entitys.Remove(Find(id));


        public List<T> Search(string term, PropertyInfo[] properties)
        {
            throw new NotImplementedException();
        }
    }
}