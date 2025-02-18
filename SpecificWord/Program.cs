namespace SpecificWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of sentence");
            int size = Convert.ToInt32(Console.ReadLine());

            string [] arr = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the {i+1} Sentence: ");
                arr[i] = Console.ReadLine();
            }

            Console.Write("Enetr the specific word to find: ");
            string word = Console.ReadLine();

            SpecificWords specific = new SpecificWords();
            



            Console.WriteLine($"Frist sentence in which {word} present:" +specific.Specific(arr, word));
        }
    }
}