//Sam’s mark in Maths is 94, Physics is 95, and Chemistry is 96 out of 100. Find the average percent mark in PCM
//I/P => NONE
//O/P => Sam’s average mark in PCM is ___

using System;

namespace Assignment{
	class AverageMarks{
		
		public static void Main(){
			
			int maths = 94;
			int physics = 95;
			int chemistry = 96;
			
			double averageMarks = (maths+physics+chemistry)*100/300;
			Console.WriteLine("Sam’s average mark in PCM is : "+averageMarks);
		}
	}
}