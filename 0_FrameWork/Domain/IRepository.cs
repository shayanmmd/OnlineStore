using System.Linq.Expressions;

namespace _0_FrameWork.Domain;

public interface IRepository<TKey,T> where T : class
{
    T Get(TKey key);
    List<T> GetAll();
    void Create(T item);
    void Update(T item);
    void Delete(T item);
    bool Exits(Expression<Func<T,bool>> expression);
    void SaveChanges();
}
