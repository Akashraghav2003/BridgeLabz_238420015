namespace TaskShedular
{
	class MyClass
	{
        static void Main(string[] args)
        {
            TaskList taskList = new TaskList();

            while (true)
            {
                Console.WriteLine("\n--- Task Scheduler Menu ---");
                Console.WriteLine("1. Insert Task at Beginning");
                Console.WriteLine("2. Insert Task at End");
                Console.WriteLine("3. Insert Task at Specific Position");
                Console.WriteLine("4. Remove Task by ID");
                Console.WriteLine("5. Display All Tasks");
                Console.WriteLine("6. Search Task by Priority");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        taskList.InsertAtBeginning();
                        break;
                    case 2:
                        taskList.InsertAtEnd();
                        break;
                    case 3:
                        taskList.InsertAtSpecific();
                        break;
                    case 4:
                        taskList.Remove();
                        break;
                    case 5:
                        taskList.Display();
                        break;
                    case 6:
                        taskList.SearchByPriority();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

    }
}
