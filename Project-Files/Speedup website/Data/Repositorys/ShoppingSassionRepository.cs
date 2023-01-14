using Speedup_website.Entitys.Orders;
using System.Reflection;

namespace Speedup_website.Data.Repositorys
{
    public class ShoppingSassionRepository : IRepository<ShoppingSassion>
    {
        List<ShoppingSassion> items;

        public ShoppingSassionRepository()
        {
            items = new List<ShoppingSassion>();
        }

        public void Add(ShoppingSassion entity)
        {
            items.Add(entity);
        }
        public int Maxid() => items.Max(item => item.id);

        public void Delete(int id)
        {
            var item = Find(id);

            if (item != null)
                items.Remove(item);
        }

        public ShoppingSassion Find(int id) => items.SingleOrDefault(i => i.id == id);

        public IList<ShoppingSassion> List()
        {
            return items.ToList();
        }

        public List<ShoppingSassion> Search(string term, PropertyInfo[] properties)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, ShoppingSassion entity)
        {
            throw new NotImplementedException();
        }
    }
}
