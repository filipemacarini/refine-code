namespace TaskManager.Refactored
{
    public class TaskManager
    {
        private readonly List<Task> _tasks = new List<Task>();

        public void AddTask(string title, string description)
        {
            var id = GetCurrentId();
            var task = new Task(id, title, description);
            _tasks.Add(task);
        }

        public void RemoveTaskById(int id) =>
            _tasks.RemoveAll(task => task.Id == id);

        public Task GetTaskById(int id)
        {
            var task = _tasks.FirstOrDefault(task => task.Id == id);
            return task;
        }

        public List<Task> GetTasks() =>
            _tasks;

        public void MarkAllTasksAs(Status status)
        {
            if (_tasks.Count == 0) return;

            foreach (var task in _tasks)
                task.MarkAs(status);
        }

        private int GetCurrentId()
        {
            if (_tasks.Count == 0) return 0;

            return _tasks.Max(task => task.Id) + 1;
        }
    }
}
