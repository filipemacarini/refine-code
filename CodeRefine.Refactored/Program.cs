namespace TaskManager.Refactored;

public class Program
{
    public static void Main(string[] args)
    {
        var taskManager = new TaskManager();

        taskManager.AddTask("Refatorar", "Refatore esse projeto em TaskManager");
        taskManager.AddTask("Apoiar", "Se inscreva no meu canal");
        taskManager.AddTask("Acompanhar", "Baixe esse projeto no meu github (na descrição)");
        taskManager.AddTask("Apoiar", "Deixa o like e comenta o que está achando da aula");

        taskManager.RemoveTaskById(0);

        taskManager.MarkAllTasksAs(Status.Completed);

        taskManager
            .GetTaskById(0) // Retorna um NullTask, pois a task com Id = 0 foi removida
            .MarkAs(Status.InProgress);

        taskManager
            .GetTaskById(-5) // Retorna um NullTask, pois não existe uma task com Id = -5
            .MarkAs(Status.InProgress);

        taskManager
            .GetTaskById(1)
            .MarkAs(Status.Completed);

        taskManager
            .GetTaskById(1)
            .MarkAs(Status.NotStarted); // Não faz nada, pois não é possível marcar como NotStarted

        //taskManager
        //    .GetTaskById(1)
        //    .Id = 2; // Não é mais possível alterar Id

        TaskPrinter.PrintTasks(taskManager.GetTasks());
    }
}
