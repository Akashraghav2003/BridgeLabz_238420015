using System;

namespace CompareStringBuilderPerformance 
{ 
    class MyClass
    {
        static void Main(string[] args)
        {
            Performancechecker performanceTrack = new Performancechecker();
            Console.WriteLine("Enter number of Iterations to check time: ");
            long iterations = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();

            long time1 = performanceTrack.PerformanceCheckStringBulider(iterations, str);
            long time2 = performanceTrack.PerformanceCheckString(iterations, str);
            Console.WriteLine($"Time taken By StringBuilder: {time1} ticks \nTime taken By String: {time2} ticks");
        }
    }
}