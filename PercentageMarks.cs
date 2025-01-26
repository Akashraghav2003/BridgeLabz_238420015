//Write a program to input marks and 3 subjects physics, chemistry and maths. 

using System;

namespace Assignment{
	
	class PercentageMarks{
		
		static void Main(){
			
			//take marks of math physics and chemistry
			Console.WriteLine("Enter the number in Math ");
			int marks1 = Convert.ToInt32(Console.ReadLine());//math marks
			
			Console.WriteLine("Enter the number in physics ");
			int marks2 = Convert.ToInt32(Console.ReadLine()); //physics marks
			
			Console.WriteLine("Enter the number in Chemistry  ");
			int marks3 = Convert.ToInt32(Console.ReadLine()); //chemistry marks
			
			//Average of three marks
			double average = (marks1+marks2+marks3)/3.0;
			
			
			//if condition used to review the student
			if(average >= 80){
				string remark = "level 4, above agency- normalized standards.";
				Console.WriteLine("Average marks is "+ average+"and remark is : "+remark);
			}else if(average >= 70 && average <= 79){
				string remark = "level 3, at agency- normalized standards.";
				Console.WriteLine("Average marks is "+ average+"and remark is : "+remark);	
			}else if(average >= 60 && average <= 69){
				string remark = "level 2, but approaching agency normalized standards.";
				Console.WriteLine("Average marks is "+ average+"and remark is : "+remark);	
			}else if(average >= 50 && average <= 59){
				string remark = "level 1,well below agency- normalized standards.";
				Console.WriteLine("Average marks is "+ average+"and remark is : "+remark);	
			}else if(average >= 40 && average <= 49){
				string remark = "level 1, too below agency- normalized standards.";
				Console.WriteLine("Average marks is "+ average+"and remark is : "+remark);	
			}else {
				string remark = "Remedial standards";
				Console.WriteLine("Average marks is "+ average+"and remark is : "+remark);
			}
			
		}
	}
}