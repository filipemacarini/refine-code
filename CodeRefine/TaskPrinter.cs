namespace TaskManager
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

            Console.WriteLine($"ID: {task.Id}");
            Console.WriteLine($"Title: {task.Title}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"Status: {task.Status}");
        }

        private static void PrintLine() => 
            Console.WriteLine("--------------------------------------------------");
    }
}
