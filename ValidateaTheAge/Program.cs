namespace ValidateaTheAge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Enter the age of person: ");
                int age = Convert.ToInt32(Console.ReadLine());

                AgeCheck.CheckError(age);


            }
            catch (AgeCheck ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}