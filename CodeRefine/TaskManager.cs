namespace TaskManager;
public class TaskManager
{
    private readonly List<Task> _tasks = new List<Task>();
    private int _idCounter = 0; 

    public void AddTask(string title, string description)
    {
        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description)) {
            Console.WriteLine("O título ou descrição passados, são/é null ou vazio");
            return;
        }

        var id = _idCounter++;
        var task = new Task(id, title, description);
        _tasks.Add(task);
    }

    public void RemoveTaskById(int id)
    {
        foreach (var task in _tasks)
        {
            if (task.Id == id)
            {
                _tasks.Remove(task);
                return;
            }
        }
    }

    public Task GetTaskById(int id)
    {
        Task returnTask = null;

        foreach (var task in _tasks)
        {
            if (task.Id == id)
            {
                returnTask = task;
    }
        }

        return returnTask;
    }

    public List<Task> GetTasks()
    {
        return _tasks;
    }

    public void MarkAllTasksAs(Status status)
    {
        if (status == Status.NotStarted) return;

        foreach (var task in _tasks)
        {
            task.Status = status;
        }
    }
}
