namespace TaskManager.Refactored;

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

        taskManager
            .GetTaskById(0)
            .MarkAs(Status.NotStarted);

        //taskManager          Não é mais possível modificar o Id de uma task
        //    .GetTaskById(1) 
        //    .Id = 2;

        taskManager
            .GetTaskById(3)
            .MarkAs(Status.InProgress);

        TaskPrinter.PrintTasks(taskManager.GetTasks());
    }
}
