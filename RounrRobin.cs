using System;

class Process
{
    public int ProcessID { get; set; } // Unique Process ID
    public int BurstTime { get; set; } // CPU execution time required
    public int RemainingTime { get; set; } // Remaining execution time
    public int WaitingTime { get; set; } // Waiting time
    public int TurnaroundTime { get; set; } // Turnaround time
    public Process Next { get; set; } // Pointer to next process in circular list

    public Process(int processID, int burstTime)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        RemainingTime = burstTime;
        WaitingTime = 0;
        TurnaroundTime = 0;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private Process head; // Head of the circular linked list
    private Process tail; // Tail pointer for circular linking
    private int timeQuantum; // Fixed time slice

    public RoundRobinScheduler(int quantum)
    {
        head = null;
        tail = null;
        timeQuantum = quantum;
    }

    // Adds a new process to the circular queue
    public void AddProcess(int processID, int burstTime)
    {
        Process newProcess = new Process(processID, burstTime);
        if (head == null)
        {
            head = newProcess;
            tail = newProcess;
            tail.Next = head; // Circular connection
        }
        else
        {
            tail.Next = newProcess;
            tail = newProcess;
            tail.Next = head; // Circular linking
        }
    }

    // Removes a process from the circular queue after execution
    private void RemoveProcess(Process prev, Process current)
    {
        if (current == head && current == tail) // Only one process in the queue
        {
            head = null;
            tail = null;
        }
        else if (current == head) // Removing head process
        {
            head = head.Next;
            tail.Next = head;
        }
        else if (current == tail) // Removing tail process
        {
            prev.Next = head;
            tail = prev;
        }
        else // Removing a middle process
        {
            prev.Next = current.Next;
        }

        Console.WriteLine($"Process {current.ProcessID} completed execution and removed.");
    }

    // Simulates the Round Robin Scheduling process
    public void ExecuteScheduling()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        int totalWaitingTime = 0;
        int totalTurnaroundTime = 0;
        int processCount = 0;

        Process current = head;
        Process prev = tail; // Keeps track of previous node for deletion

        Console.WriteLine("\nExecuting Round Robin Scheduling...");

        int elapsedTime = 0; // Tracks total elapsed execution time

        while (head != null)
        {
            if (current.RemainingTime > 0)
            {
                int executionTime = Math.Min(timeQuantum, current.RemainingTime);
                Console.WriteLine($"Executing Process {current.ProcessID} for {executionTime} units.");

                elapsedTime += executionTime;
                current.RemainingTime -= executionTime;

                if (current.RemainingTime == 0)
                {
                    // Process completed
                    current.TurnaroundTime = elapsedTime;
                    current.WaitingTime = current.TurnaroundTime - current.BurstTime;

                    totalWaitingTime += current.WaitingTime;
                    totalTurnaroundTime += current.TurnaroundTime;
                    processCount++;

                    // Remove completed process
                    RemoveProcess(prev, current);
                    
                    // Adjust pointers
                    current = prev.Next;
                    continue;
                }
            }

            prev = current;
            current = current.Next;
        }

        // Display Average Waiting and Turnaround Time
        Console.WriteLine("\nScheduling Complete.");
        if (processCount > 0)
        {
            Console.WriteLine($"Average Waiting Time: {(float)totalWaitingTime / processCount}");
            Console.WriteLine($"Average Turnaround Time: {(float)totalTurnaroundTime / processCount}");
        }
    }

    // Displays all processes in the queue
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        Console.WriteLine("\nProcesses in the circular queue:");
        Process temp = head;
        do
        {
            Console.WriteLine($"Process ID: {temp.ProcessID}, Burst Time: {temp.BurstTime}, Remaining Time: {temp.RemainingTime}");
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(4); // Setting time quantum to 4 units

        // Adding processes
        scheduler.AddProcess(1, 10);
        scheduler.AddProcess(2, 5);
        scheduler.AddProcess(3, 8);
        scheduler.AddProcess(4, 6);

        scheduler.DisplayProcesses(); // Display all processes before execution

        scheduler.ExecuteScheduling(); // Start the scheduling

        scheduler.DisplayProcesses(); // Display remaining processes after scheduling (should be empty)
    }
}