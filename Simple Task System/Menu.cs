namespace Simple_Task_System
{
    internal class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("-| Simple Task System |-");
            Console.WriteLine("\n1. Display Tasks");
            Console.WriteLine("2. Create Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Update Task");
            Console.WriteLine("0. Exit Application");

            Console.Write("Please select an option: ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    DisplayTasks();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    CreateTask();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    DeleteTask();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    UpdateTask();
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    Console.WriteLine("Exiting application...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option selected.");
                    DisplayMenu();
                    break;
            }
        }

        private static void DisplayTasks()
        {
            if (Task.GetTasks().Count == 0)
            {
                Console.WriteLine("No tasks to display.\n");
                ReturnToMenu();
                return;
            }

            foreach (Task task in Task.GetTasks())
            {
                Console.WriteLine($"Task Name: {task.TaskName}");
                Console.WriteLine($"Description: {task.TaskDescription}\n");
            }

            ReturnToMenu();
        }

        private static void CreateTask()
        {
            //Repeat until valid input is given
            while (true)
            {
                Console.Write("Enter task name: ");
                string taskName = Console.ReadLine()!;

                Console.Write("Enter task description: ");
                string taskDescription = Console.ReadLine()!;

                //If the user enters a blank task name or description, repeat the loop
                if (taskName == "" || taskDescription == "")
                {
                    Console.WriteLine("Task name or description cannot be blank.");
                    continue;
                }

                //Create a new task object and add it to the list of tasks
                Task.GetTasks().Add(new Task(taskName, taskDescription));
                Console.WriteLine("Task added successfully.\n");
                ReturnToMenu();
                return;
            }
        }

        private static void DeleteTask()
        {
            if (Task.GetTasks().Count != 0)
            {
                int taskId = 1;
                foreach (Task task in Task.GetTasks())
                {
                    Console.WriteLine($"Task ID: {taskId}");
                    Console.WriteLine($"Task Name: {task.TaskName}");
                    Console.WriteLine($"Description: {task.TaskDescription}\n");
                    taskId++;
                }

                Console.Write("Enter the ID of the task you wish to delete: ");
                string input = Console.ReadLine()!;
                if (int.TryParse(input, out int taskToDelete))
                {
                    if (taskToDelete > 0 && taskToDelete <= Task.GetTasks().Count)
                    {
                        Task.GetTasks().RemoveAt(taskToDelete - 1);
                        Console.WriteLine("Task deleted successfully.\n");
                        ReturnToMenu();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid task ID entered.");
                        DeleteTask();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid task ID entered.");
                    DeleteTask();
                }
            }
            else
            {
                Console.WriteLine("No tasks to display.");
                ReturnToMenu();
            }
        }

        private static void UpdateTask()
        {

        }

        private static void ReturnToMenu()
        {
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
            DisplayMenu();
        }
    }
}
