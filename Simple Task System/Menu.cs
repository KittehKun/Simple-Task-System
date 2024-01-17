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
            Console.WriteLine("Displaying tasks...");
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
                Console.WriteLine("Task has been added. Press any key to return to the main menu.");
                Console.ReadKey();
                Console.Clear();
                DisplayMenu();
                return;
            }
        }

        private static void DeleteTask()
        {
            Console.WriteLine("Deleting task...");
        }

        private static void UpdateTask()
        {
            Console.WriteLine("Updating task...");
        }
    }
}
