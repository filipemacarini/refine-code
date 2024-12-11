namespace TaskManager;
public static class TaskPrinter
{
    private static int _printsCounter = 1;

    public static void PrintTasks(List<Task> tasks)
    {
        PrintLine();
        Console.WriteLine($"Exibindo lista pela {_printsCounter}º vez");
        _printsCounter++;

        foreach (Task task in tasks)
        {
            PrintTask(task);
        }
    }

    public static void PrintTask(Task task)
    {
        PrintLine();

        PrintPropertie(nameof(task.Id), task.Id);
        PrintPropertie(nameof(task.Title), task.Title);
        PrintPropertie(nameof(task.Description), task.Description);
        PrintPropertie(nameof(task.Status), task.Status);
    }

    public static void PrintPropertie(string name, object value)
    {
        Console.WriteLine($"{name}: {value}");
    }

    private static void PrintLine()
    {
        Console.WriteLine("--------------------------------------------------");
    } 
}
