namespace QueueUsingStack
{
	class Program
	{
        int item;
        
        public int  GetDetails()
        {
            Console.WriteLine("Enetr the item");
            item = Convert.ToInt32(Console.ReadLine());
            return item;
        }
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            Program program = new Program();

            while (true)
            {
                Console.WriteLine("Choose the operation");
                Console.WriteLine(" 1.Enqueue\n 2.Dequeue \n 3.IsEmpty \n 4.Exits");

                int operation = Convert.ToInt32( Console.ReadLine());

                switch(operation)
                {
                    case 1:
                        program.GetDetails();
                        queue.Enqueue(program.item);
                        break;
                    case 2:
                        Console.WriteLine("Dequeue item is: "+queue.Dequeue()); 
                        break;
                    case 3:
                        if (queue.IsEmpty())
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        else
                        {
                            Console.WriteLine("Queue is not Empty");
                        }
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Choose the corect opeartion");
                        break;

                }

            }
        }
    }
}