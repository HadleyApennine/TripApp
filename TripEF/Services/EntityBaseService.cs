using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TripEF.Services;

public class EntityBaseService<T> : IEntityBaseService<T> where T : class, IEntityBase, new()
{
    private readonly AppDbContextFactory _context; // deklaruje ten obiekt al eon jest pusty

    public EntityBaseService(AppDbContextFactory context)
    {
        _context = context; // przypisuję do obiektu
    }

    public void AddAsync(T entity)
    {
        using AppDbContext appContext = _context.CreateDbContext(); // deklarujemy obiekt na czas zycia miedzy klamrami
        {
            appContext.Set<T>().Add(entity); // Dodajemy do tabelki obiekt entity
            appContext.SaveChanges(); // zapisujemy zmiany
        } // (w tym miejscu ten oboekt przestaje istniec)
    }

/// <summary>
///  Funkcja która updateuje rekord w bazie danych
/// </summary>
/// <param name="entity"></param>
    public void Update(T entity)
    {
        using AppDbContext appContext = _context.CreateDbContext(); // deklarujemy obiekt na czas zycia miedzy klamrami
        {
            appContext.Set<T>().Update(entity); // AKTUALIZUJEMY tabelkę (obiekt)
            appContext.SaveChanges(); // zapisujemy zmiany
        } // (w tym miejscu ten oboekt przestaje istniec)
    }

    public void Remove(int id)
    {
        using AppDbContext appContext = _context.CreateDbContext(); // deklarujemy obiekt na czas zycia miedzy klamrami
        {
            var item = appContext.Set<T>().FirstOrDefault(x => x.TripID == id);
            appContext.Set<T>().Remove(item);
            // Usuwamy obiekt z tabelki
            appContext.SaveChanges(); // zapisujemy zmiany
        } // (w tym miejscu ten oboekt przestaje istniec)
    }


    public T GetById(int id)
    {
        using AppDbContext appContext = _context.CreateDbContext(); // deklarujemy obiekt na czas zycia miedzy klamrami
        {
            return appContext.Set<T>().FirstOrDefault(x=>x.TripID == id); // Zwracamy 
        } // (w tym miejscu ten oboekt przestaje istniec)
    }

    public List<T> GetAll()
    {
        using AppDbContext appContext = _context.CreateDbContext(); // deklarujemy obiekt na czas zycia miedzy klamrami
        {
            return appContext.Set<T>().ToList<T>(); // Zwracamy cala tabelke w postaci listy 
        } // (w tym miejscu ten oboekt przestaje istniec)
    }
}