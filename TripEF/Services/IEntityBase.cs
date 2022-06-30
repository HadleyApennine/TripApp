namespace TripEF.Services;

public interface IEntityBase
{/// <summary>
 /// Unikalne ID
 /// </summary>
    public int TripID { get; set; }
 
 /// <summary>
 /// Nazwa przedmiotu
 /// </summary>
    public string Name { get; set; }
}