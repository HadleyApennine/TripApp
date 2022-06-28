namespace TripEF.Services;

public interface IEntityBaseService<T> where T : class, IEntityBase, new()
{
    void AddAsync(T entity);
    List<T> GetAll();
    T GetById(int id);
    void Remove(int id);
    void Update(T entity);
}