namespace Simple_Task_System
{
    internal class Task
    {
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
    }
}
