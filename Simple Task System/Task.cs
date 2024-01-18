namespace Simple_Task_System
{
    internal class Task
    {
        //Global Variables
        private static List<Task> Tasks = new List<Task>();
        public static List<Task> GetTasks() { return Tasks; }

        //Fields
        private string _taskName;
        private string _taskDescription;

        //Properties
        public string TaskName { get { return _taskName; } }
        public string TaskDescription { get { return _taskDescription; } }

        //Constructors
        public Task(string taskName, string taskDescription)
        {
            _taskName = taskName;
            _taskDescription = taskDescription;
        }

        //Methods
        public void UpdateTask(string taskName, string taskDescription)
        {
            _taskName = taskName;
            _taskDescription = taskDescription;
        }
    }
}
