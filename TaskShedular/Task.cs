using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskShedular
{
    internal class Task
    {
        public string TaskName { get; set; }
        public int TaskId { get; set; }
        public int Priority { get; set; }

        public DateOnly DueDate { get; set; }
        public Task Next { get; set; }
        public Task Prev {  get; set; }

        public Task(string taskName, int taskId, int priority, DateOnly dueDate)
        {
            TaskName = taskName;
            TaskId = taskId;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
            Prev = null;
        }
    }
}
