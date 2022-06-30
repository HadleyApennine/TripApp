namespace TripEF.Services;

public interface IEntityBaseService<T> where T : class, IEntityBase, new()
{/// <summary>
 /// Metoda na dodanie rekordu do bazy danych klasy generycznej T
 /// </summary>
 /// <param name="entity"></param>
    void AddAsync(T entity);
 /// <summary>
 /// Metoda na pobranie wszystkich rekordow z tabeli generycznej T
 /// </summary>
 /// <returns></returns>
    List<T> GetAll();
 /// <summary>
 /// Pobranie konkretnego rekordu z tabeli po ID
 /// </summary>
 /// <param name="id"></param>
 /// <returns></returns>
    T GetById(int id);
 /// <summary>
 /// Usuniecie konkretnego rekordu z tabeli po ID
 /// </summary>
 /// <param name="id"></param>
    void Remove(int id);
 /// <summary>
 /// Edycja konkretnego rekordu z tabeli po ID 
 /// </summary>
 /// <param name="entity"></param>
    void Update(T entity);
}