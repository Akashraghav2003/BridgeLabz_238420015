﻿namespace SelectionSort
{
	class Program
	{

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of student");
            int student = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[student];

            
            for (int i = 0; i < student; i++)
            {
                Console.WriteLine($"Enter the {i+1}. Student marks");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Selection selection = new Selection();
            selection.Display(arr);

            selection.Sort(arr);
            Console.WriteLine("Array afrter bubble sorting ");
            selection.Display(arr);

            
        }
    }
}