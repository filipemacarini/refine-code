namespace TaskManager;

public class Program
{
    public static void Main(string[] args)
    {
        var taskManager = new TaskManager();

        taskManager.AddTask("Refatorar", "Refatore esse projeto em TaskManager.Refactored");
        taskManager.AddTask("Apoiar", "Se inscreva no meu canal"); 

        TaskPrinter.PrintTasks(taskManager.GetTasks());

        taskManager.AddTask("Acompanhe", "Baixe esse projeto no meu github (na descrição)");
        taskManager.RemoveTaskById(0);

        taskManager.MarkAllTasksAs(Status.Completed);

        TaskPrinter.PrintTasks(taskManager.GetTasks());
    }
}
