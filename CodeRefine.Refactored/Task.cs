namespace TaskManager.Refactored;
public class Task : AbstractTask
{
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Status Status { get; private set; }

    public Task(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        Status = Status.NotStarted;
    }

    public override void MarkAs(Status status)
    {
        if (status == Status.NotStarted) return;
        Status = status;
    }
}
