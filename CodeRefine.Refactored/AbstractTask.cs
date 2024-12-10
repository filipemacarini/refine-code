namespace TaskManager.Refactored;
public abstract class AbstractTask
{
    public abstract void MarkAs(Status status);
    public abstract void PrintPropertie(string name, object value);

    public static readonly AbstractTask NULL = new NullTask();

    private class NullTask : AbstractTask
    {
        public NullTask() { }
        public override void MarkAs(Status status) { }
        public override void PrintPropertie(string name, object value) { }
    }
}