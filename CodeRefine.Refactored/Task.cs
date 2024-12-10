namespace TaskManager.Refactored
{
    public class Task : ITask1
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

        public void MarkAs(Status status) =>
            Status = status;

        public void PrintPropertie(string name, object value) =>
            Console.WriteLine($"{name}: {value}");
    }
}
