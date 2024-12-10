namespace TaskManager.Refactored
{
    public class TaskManager
    {
        private readonly List<Task> _tasks;

        public void AddTask(string title, string description)
        {
            var id = _tasks.Max(task => task.Id);
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
    }
}
