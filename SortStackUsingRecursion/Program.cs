namespace SortStackUsingRecursion
{
    class Program
    {
        int item;

        public void GetDetails()
        {
            Console.WriteLine("Enetr the item");
            item = Convert.ToInt32(Console.ReadLine());
    
        }
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Program program = new Program();

            while (true)
            {
                Console.WriteLine("Choose the operation");
                Console.WriteLine(" 1.Push\n 2.Pop \n 3.IsEmpty \n 4.Peek\n 5.Sort \n 6.Display \n 7.Exits");

                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        program.GetDetails();
                        stack.Push(program.item);
                        break;
                    case 2:
                        Console.WriteLine("pop item is: " + stack.Pop());
                        break;
                    case 3:
                        if (stack.isEmpty())
                        {
                            Console.WriteLine("stack is empty");
                        }
                        else
                        {
                            Console.WriteLine("stack is not Empty");
                        }
                        break;
                    case 4:
                        Console.WriteLine("peek element is:  "+stack.Peek());
                        break;
                    case 5:
                        stack.Sort();
                        break;
                    case 6:
                        stack.Display();
                        break;
                    case 7:
                        return;
                        
                    default:
                        Console.WriteLine("Choose the corect opeartion");
                        break;

                }

            }
        }
    }
}
