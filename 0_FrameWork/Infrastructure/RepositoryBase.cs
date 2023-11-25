using _0_FrameWork.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace _0_FrameWork.Infrastructure;

public class RepositoryBase<TKey, T> : IRepository<TKey, T> where T : class
{
    private readonly DbContext _context;

    public RepositoryBase(DbContext context)
    {
        _context = context;
    }

    public void Create(T item)
    {
        _context.Add<T>(item);
    }
    public void Delete(T item)
    {
        _context.Remove<T>(item);
    }
    public T Get(TKey key)
    {
        return _context.Find<T>(key);
    }
    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }
    public void Update(T item)
    {
        _context.Update<T>(item);
    }
    public void SaveChanges()
    {
        _context.SaveChanges();
    }
    public bool Exits(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Any(expression);
    }
}
