namespace TaskManager.Refactored;
public static class TaskPrinter
{
    private static int _printsCounter = 1;

    public static void PrintTasks(List<AbstractTask> tasks)
    {
        if (tasks == null)
        {
            Console.WriteLine("Lista de Tasks passada é nula");
            return;
        }

        PrintLine();
        Console.WriteLine($"Exibindo lista pela {_printsCounter}º vez");
        _printsCounter++;

        foreach (Task task in tasks)
            PrintTask(task);
    }

    public static void PrintTask(AbstractTask task)
    {
        PrintLine();

        PrintPropertie(nameof(task.Id), task.Id);
        PrintPropertie(nameof(task.Title), task.Title);
        PrintPropertie(nameof(task.Description), task.Description);
        PrintPropertie(nameof(task.Status), task.Status);
    }

    public static void PrintPropertie(string name, object value)
    {
        if (name == null || value == null)
        {
            Console.WriteLine("Nome ou Valor são/é nulos");
            return;
        }
        Console.WriteLine($"{name}: {value}");
    }

    private static void PrintLine() => 
        Console.WriteLine("--------------------------------------------------");
}