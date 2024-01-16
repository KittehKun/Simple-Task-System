namespace Simple_Task_System
{
    //This class will handle CRUD operations of Task objects by storing them in a list
    internal class TaskLibrary
    {
        //Fields
        private List<Task> _tasks;

        //Constructor
        public TaskLibrary()
        {
            _tasks = new List<Task>();
        }

        //Methods
        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            _tasks.Remove(task);
        }

        public void Clear()
        {
            _tasks.Clear();
        }
    }
}
