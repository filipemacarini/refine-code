namespace TaskManager.Refactored;
public class Task : AbstractTask
{
    public override int Id { get; }
    public override string Title { get; set; }
    public override string Description { get; set; }
    public override Status Status { get; protected set; }

    public Task(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        Status = Status.NotStarted;
    }

    public override void MarkAs(Status status)
    {
        if (status != Status.NotStarted)
            Status = status;
    }
}
