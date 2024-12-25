namespace TaskManager;

public class Program
{
    public static void Main(string[] args)
    {
        var taskManager = new TaskManager();

        taskManager.AddTask("Refatorar", "Refatore esse projeto em TaskManager");
        taskManager.AddTask("Apoiar", "Se inscreva no meu canal");
        taskManager.AddTask("Apoiar", "Deixa o like e comenta o que está achando da aula");
        taskManager.AddTask("Acompanhar", "Baixe esse projeto no meu github (na descrição)");

        TaskPrinter.PrintTasks(taskManager.GetTasks());

        TaskPrinter.PrintTask(null);
    }
}
