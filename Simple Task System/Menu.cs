namespace Simple_Task_System
{
    internal class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("-| Simple Task System |-");
            Console.WriteLine("1. Display Tasks");
            Console.WriteLine("2. Create Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Update Task");

            Console.Write("Please select an option: ");
        }
    }
}
