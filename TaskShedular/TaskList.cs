using System;

namespace TaskShedular
{
    internal class TaskList
    {
        private Task head;

        public void GetDetails(out string taskName, out int taskId, out int priority, out DateOnly dueDate)
        {
            Console.WriteLine("Enter the Task Name: ");
            taskName = Console.ReadLine();

            Console.WriteLine("Enter the Task ID: ");
            taskId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Priority number: ");
            priority = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Date in dd/mm/yyyy format: ");
            string input = Console.ReadLine();
            dueDate = DateOnly.Parse(input);
        }

        public void InsertAtBeginning()
        {
            string taskName;
            int taskId;
            int priority;
            DateOnly dueDate;
            GetDetails(out taskName, out taskId, out priority, out dueDate);

            Task newTask = new Task(taskName, taskId, priority, dueDate);

            if (head == null)
            {
                head = newTask;
                head.Next = head;
                head.Prev = head;
                return;
            }

            Task tail = head.Prev;
            newTask.Next = head;
            newTask.Prev = tail;
            tail.Next = newTask;
            head.Prev = newTask;
            head = newTask;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Task temp = head;
            do
            {
                Console.WriteLine($"Task Name: {temp.TaskName}, Task Id: {temp.TaskId}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
                temp = temp.Next;
            } while (temp != head);

            
        }

        public void InsertAtEnd()
        {
            string taskName;
            int taskId;
            int priority;
            DateOnly dueDate;
            GetDetails(out taskName, out taskId, out priority, out dueDate);

            Task newTask = new Task(taskName, taskId, priority, dueDate);

            if (head == null)
            {
                head = newTask;
                head.Next = head;
                head.Prev = head;
                return;
            }

            Task tail = head.Prev;
            tail.Next = newTask;
            newTask.Prev = tail;
            newTask.Next = head;
            head.Prev = newTask;

            Console.WriteLine("Task added at the end.");
        }

        public void InsertAtSpecific()
        {
            Console.WriteLine("Enter the position:");
            int position = Convert.ToInt32(Console.ReadLine());

            if (position < 1)
            {
                Console.WriteLine("Enter a valid position.");
                return;
            }

            if (position == 1)
            {
                InsertAtBeginning();
                return;
            }

            string taskName;
            int taskId;
            int priority;
            DateOnly dueDate;
            GetDetails(out taskName, out taskId, out priority, out dueDate);

            Task newTask = new Task(taskName, taskId, priority, dueDate);

            Task temp = head;
            for (int i = 1; temp.Next != head && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp.Next == head)
            {
                Console.WriteLine("Position out of range.");
                return;
            }

            newTask.Next = temp.Next;
            newTask.Prev = temp;
            temp.Next.Prev = newTask;
            temp.Next = newTask;

            Console.WriteLine("Task added at the specified position.");
        }

        public void Remove()
        {
            Console.WriteLine("Enter the task ID to remove: ");
            int taskId = Convert.ToInt32(Console.ReadLine());

            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Task temp = head;

            do
            {
                if (temp.TaskId == taskId)
                {
                    if (temp == head && temp.Next == head) // Only one node in the list
                    {
                        head = null;
                    }
                    else
                    {
                        Task prevNode = temp.Prev;
                        Task nextNode = temp.Next;

                        prevNode.Next = nextNode;
                        nextNode.Prev = prevNode;

                        if (temp == head) // If the node to be deleted is head, update head
                        {
                            head = nextNode;
                        }
                    }

                    Console.WriteLine($"Task {taskId} removed.");
                    return;
                }
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("Task not found.");
        }

        public void SearchByPriority()
        {
            Console.WriteLine("Enter the priority to search: ");
            int priority = Convert.ToInt32(Console.ReadLine());

            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Task temp = head;
            bool found = false;

            do
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine($"Task Found - Name: {temp.TaskName}, ID: {temp.TaskId}, Due Date: {temp.DueDate}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
            {
                Console.WriteLine("No task found with the given priority.");
            }
        }
    }
}

