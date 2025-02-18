using System.Text;

namespace RemoveDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the strig");
            StringBuilder sb = new StringBuilder(Console.ReadLine());

            Remove remove = new Remove();

            Console.WriteLine("String After remove duplicates: " + remove.RemoveDuplicates(sb));
        }
    }
}