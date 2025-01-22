//Suppose you have to divide 14 pens among 3 students equally. 
//Write a program to find how many pens each student will get if the pens must be divided equally.
//Also, find the remaining non-distributed pens.

using System;

namespace Assignment{
	
	class PenDistribution {
		
		static void Main(){
			//number of pens
			int totalPens = 14;
			//no of students
			int totalStudents = 3;
			
			//compute the pens per student
			int penPerStudent = totalPens/totalStudents;
			//compute the remaining Pen
			int remainingPen = totalPens%totalStudents;
			
			//final result
			Console.WriteLine("The Pen per student is "+penPerStudent +" and the remaning pen not distributed is "+remainingPen); 
		}
	}
}