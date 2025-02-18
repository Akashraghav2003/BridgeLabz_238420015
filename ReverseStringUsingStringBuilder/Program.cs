using System.Text;

namespace ReverseStringUsingStringBuilder
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the strig");
            StringBuilder sb = new StringBuilder(Console.ReadLine());

            ReverseString reverseString = new ReverseString();

            Console.WriteLine("Reversed string is :" + reverseString.Reverse(sb));
        }
    }
}