namespace FrequencyOfElements
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter the element of list:");
            string[] input = Console.ReadLine().Split(' ');

			List<string> list = input.ToList();

			Frequency frequency = new Frequency();
			 Dictionary<string, int> dict = frequency.Occurance(list);

			foreach(var item in dict)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}


        }
	}
}