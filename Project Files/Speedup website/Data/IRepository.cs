namespace Speedup_website.Data
{
    public interface IRepository<T> where T : class
    {
        IList<T> List();
        T Find(int id);
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        List<T> Search(string term,System.Reflection.PropertyInfo[] properties);
    }
}
