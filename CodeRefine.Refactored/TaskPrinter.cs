using System.Threading.Tasks;

namespace TaskManager.Refactored
{
    public static class TaskPrinter
    {
        private static int _printsCounter = 1;

        public static void PrintTasks(List<Task> tasks)
        {
            PrintLine();
            Console.WriteLine($"Exibindo lista pela {_printsCounter}º vez");
            _printsCounter++;

            foreach (Task task in tasks)
                PrintTask(task);
        }

        public static void PrintTask(Task task)
        {
            PrintLine();

            task.PrintPropertie(nameof(task.Id), task.Id);
            task.PrintPropertie(nameof(task.Title), task.Title);
            task.PrintPropertie(nameof(task.Description), task.Description);
            task.PrintPropertie(nameof(task.Status), task.Status);
        }

        private static void PrintLine() => 
            Console.WriteLine("--------------------------------------------------");
    }
}
