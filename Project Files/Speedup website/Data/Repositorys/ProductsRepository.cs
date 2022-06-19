using Speedup_website.Entitys.Products;
using System.Reflection;

namespace Speedup_website.Data.Repositorys
{
    public class ProductsRepository : IRepository<Product>
    {
        IList<Product> products;

        public static PropertyInfo[] properties = typeof(Product).GetProperties();

        public ProductsRepository()
        {
            products = new List<Product>{new Product
            {
                id = 1,
                name = "product1"
            }
            };
        }

        public void Add(Product entity)
        {
            entity.id = products.Max(p => p.id) + 1;

            products.Add(entity);
        }

        public void Delete(int id)
        {
            var item = Find(id);

            if (item != null)
                products.Remove(item);
        }

        public Product Find(int id) => products.SingleOrDefault(p => p.id == id) ?? new Product();

        public IList<Product> List() => products;


        public List<Product> Search(string term,PropertyInfo[] properties)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product entity)
        {
            Product p = Find(id);


            for (int i = 0; i < properties.Length; i++)
            {
                p.GetType()
                    .GetProperty(properties[i].Name)
                    .SetValue(entity, properties[i], null);
            }
        }
    }
}