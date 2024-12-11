namespace TaskManager;

public class Program
{
    public static void Main(string[] args)
    {
        var taskManager = new TaskManager();

        taskManager.AddTask("Refatorar", "Refatore esse projeto em TaskManager.Refactored");
        taskManager.AddTask("Apoiar", "Se inscreva no meu canal");
        taskManager.AddTask("Acompanhar", "Baixe esse projeto no meu github (na descrição)");
        taskManager.AddTask("Apoiar", "Deixa o like e comenta o que está achando da aula");

        taskManager.RemoveTaskById(0);

        taskManager.MarkAllTasksAs(Status.Completed);

        if (taskManager.GetTaskById(0) != null)
        {
            taskManager
                .GetTaskById(0)
                .Status = Status.NotStarted;
        }

        var task = taskManager.GetTaskById(0);
        if (task != null)
        {
            task.Status = Status.NotStarted;
        }

        if (taskManager.GetTaskById(1) != null)
        {
            taskManager
                .GetTaskById(1)
                .Id = 2;
        }

        if (taskManager.GetTaskById(3) != null)
        {
            taskManager
                .GetTaskById(3)
                .Status = Status.InProgress;
        }

        TaskPrinter.PrintTasks(taskManager.GetTasks());
    }
}
