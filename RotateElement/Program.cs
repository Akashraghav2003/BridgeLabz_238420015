using System.Collections.Generic;

namespace RotateElement
{
	class Program
	{
        static void Main(string[] args)
        {
            RotateElementInList rotateElementInList = new RotateElementInList();    
            Console.WriteLine("Enter the element of list with space: ");
            string[] inputArray = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();   
            foreach (string input in inputArray)
            {
                if (int.TryParse(input, out int value))
                {
                    list.Add(value);
                }
            }
            Console.Write("Enter the index to rotate: ");
            int index = Convert.ToInt32(Console.ReadLine());
            List <int> results = rotateElementInList.Rotate(list, index);

            foreach(var result in results)
            {
                Console.Write(result+ " ");
            }
        }
    }
}