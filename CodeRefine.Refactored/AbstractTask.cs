namespace TaskManager.Refactored;
public abstract class AbstractTask
{
    public abstract int Id { get; }
    public abstract string Title { get; set; }
    public abstract string Description { get; set; }
    public abstract Status Status { get; protected set; }

    public abstract void MarkAs(Status status);

    public static readonly AbstractTask NULL = new NullTask();

    private class NullTask : AbstractTask
    {
        public override int Id { get; } = -1;
        public override string Title { get; set; } = "Task nula";
        public override string Description { get; set; } = "Esta é uma task nula";
        public override Status Status { get; protected set; } = Status.NotStarted;
        public NullTask() { }
        public override void MarkAs(Status status) { }
    }
}