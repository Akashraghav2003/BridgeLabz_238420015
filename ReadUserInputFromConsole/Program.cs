class Program
{
    static void Main(string[] args)
    {
        string path = @"D:\akash gla university\capgemini problem\feature20-02-2025\ReadUserInputFromConsole\new.txt";

        try
        {
            Console.WriteLine("Enetr the number of student you want to store: ");
            int num = Convert.ToInt32(Console.ReadLine());
            

            
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (int i = 0; i < num; i++)
                    {
                        Console.Write("Enter the Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter favourit Language: ");
                        string language = Console.ReadLine();

                        sw.WriteLine(name);
                        sw.WriteLine(age);
                        sw.WriteLine(language);


                    }
                }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}