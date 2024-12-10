namespace TaskManager.Refactored;
public interface ITask
{
    string Description { get; set; }
    int Id { get; }
    Status Status { get; }
    string Title { get; set; }

    public static readonly NullTask NULL = new NullTask();

    void MarkAs(Status status);
    void PrintPropertie(string name, object value);

    public class NullTask : ITask
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; }

        public void MarkAs(Status status) { }
        public void PrintPropertie(string name, object value) { }
    }
}