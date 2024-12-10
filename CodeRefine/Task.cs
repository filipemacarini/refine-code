namespace TaskManager;
public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }

    public Task(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        Status = Status.NotStarted;
    }

    public void PrintPropertie(string name, object value) =>
        Console.WriteLine($"{name}: {value}");
}
