class MyClass
{
    static void Main(string[] args)
    {
        try
        {
            

            Console.WriteLine("Enter the size of array");
            int num =Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];

            Console.WriteLine("Enter the element with space of the array");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine()) ;
            }

            Console.Write("Enter the index value do you want: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Value at {index} is: " + arr[index]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("You give the out of range value: " + ex.Message);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Array is null: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}