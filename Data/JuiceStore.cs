using MyWebApi.Models;

namespace MyWebApi.Data;

public class JuiceStore
{
    private readonly List<Juice> _juices = new()
    {
        new Juice { Id = 1, Name = "Jus Mangga", Description = "Mangga segar", Price = 12000, IsAvailable = true },
        new Juice { Id = 2, Name = "Jus Alpukat", Description = "Alpukat dan susu", Price = 15000, IsAvailable = true }
    };

    private int _nextId = 3;

    public IReadOnlyList<Juice> GetAll() => _juices;

    public Juice? GetById(int id) => _juices.FirstOrDefault(juice => juice.Id == id);

    public Juice Create(Juice juice)
    {
        juice.Id = _nextId++;
        _juices.Add(juice);
        return juice;
    }

    public bool Update(int id, Juice updatedJuice)
    {
        var juice = GetById(id);
        if (juice is null)
        {
            return false;
        }

        juice.Name = updatedJuice.Name;
        juice.Description = updatedJuice.Description;
        juice.Price = updatedJuice.Price;
        juice.IsAvailable = updatedJuice.IsAvailable;
        return true;
    }

    public bool Delete(int id)
    {
        var juice = GetById(id);
        return juice is not null && _juices.Remove(juice);
    }
}
