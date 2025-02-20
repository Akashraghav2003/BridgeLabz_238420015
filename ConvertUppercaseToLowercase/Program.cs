class Program
{
    static void Main(string[] args)
    {
        try
        {
            string path = @"D:\akash gla university\capgemini problem\feature20-02-2025\ConvertUppercaseToLowercase\upper.txt";
            string des = @"D:\akash gla university\capgemini problem\feature20-02-2025\ConvertUppercaseToLowercase\Lower.txt";

            using(StreamReader sr = new StreamReader(path))
            using(StreamWriter sr2 = new StreamWriter(des))
            
            {
                string line;
                while((line =sr.ReadLine()) != null)
                {
                    sr2.WriteLine(line.ToLower());
                }

                Console.WriteLine("File copied in To Lower");
            }


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}