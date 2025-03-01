namespace HandlingFileNotFoundException
{
	class Program
	{
        static void Main(string[] args)
        {
            FileHandling fh = new FileHandling();
            string path = @"D:\akash gla university\capgemini problem\feature21-02-2025\HandlingFileNotFoundException\new file.txt";

            try
            {
                fh.ReadFile(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}