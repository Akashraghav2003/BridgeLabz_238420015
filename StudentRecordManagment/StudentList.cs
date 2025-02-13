using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace StudentRecordManagment
{
    internal class StudentList
    {
        private Student head;


        public void GetDetails(out int rollno, out string name, out int age, out char grade)
        {
            Console.WriteLine("Enter the rollno");
            rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name of student");
            name = Console.ReadLine();

            Console.WriteLine("Enter the age of student");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the grade of student");
            grade = Console.ReadLine()[0];


        }
        public void InsertAtEnd()
        {
            int rollno;
            string name;
            int age;
            char grade;
            GetDetails(out rollno, out name, out age, out grade);

            Student newStudent = new Student(rollno, name, age, grade);
            
            if(head == null)
            {
                head = newStudent;
                return;
            }

            Student temp = head;
            
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStudent;

        }


        

        public void InsertAtBeginning()
        {
            int rollno;
            string name;
            int age;    
            char grade;
            GetDetails(out rollno, out name,out age, out grade );
            
            Student newStudent = new Student (rollno, name, age, grade);

            newStudent.Next = head;
            head = newStudent;
        }

        public void InsertAtSpecific()
        {
            
            Console.WriteLine("Enter the position that i was insert");
            int position = Convert.ToInt32(Console.ReadLine());

            if (position < 1)
            {
                Console.WriteLine("Enter the valid position");
            }
            if(position == 1)
            {
                InsertAtBeginning();
                return;
            }

            int rollno;
            string name;
            int age;
            char grade;
            GetDetails(out rollno, out name, out age, out grade);
            Student newStudent = new Student(rollno, name, age, grade); 
            Student temp = head;

            for (int i = 1; temp != null && i<position-1; i++)
            {
                temp = temp.Next;
            }

            if(temp == null)
            {
                Console.WriteLine("Position out of index");
                return;
            }
            newStudent.Next = temp.Next;
            temp.Next = newStudent;
        }

        public void DeleteStudent ()
        {
            Console.WriteLine("Enter the rollno ");
            int rollno = Convert.ToInt32(Console.ReadLine());

            if(head == null)
            {
                Console.WriteLine("Linked LIst is empty");
                return;
            }
            if(head.RollNumber.Equals(rollno))
            {
                head = head.Next;
                return;
            }

            Student temp = head;
            Student prev = null;

            while(temp != null && temp.RollNumber != rollno)
            {
                prev = temp;
                temp = temp.Next; 
            }
            if (temp == null)
            {
                Console.WriteLine("Roll number is not present in the link list");
                return;
            }

            if (temp.RollNumber.Equals(rollno))
            {
                prev.Next = temp.Next;
                return;
            }
            
        }

        public void SearchStudent()
        {
            Console.WriteLine("Enter the rollno ");
            int rollno = Convert.ToInt32(Console.ReadLine());
            
            if(head == null)
            {
                Console.WriteLine("list is empty");
                return;
            }

            Student temp = head;

            while(temp != null && temp.RollNumber != rollno)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Roll number is not present in the link list");
                return;
            }

            if (temp.RollNumber.Equals(rollno))
            {
                Console.WriteLine($"Roll number {temp.RollNumber}, Name of student {temp.Name}, Age of student {temp.Age}, grade of Student {temp.Grade}");
            }

            


        }

        public void DisplayStudent()
        {
            if (head == null)
            {
                Console.WriteLine("student not found");
            }

            Student temp = head;

            while(temp != null)
            {
                Console.WriteLine($"Roll number {temp.RollNumber}, Name of student {temp.Name}, Age of student {temp.Age}, grade of Student {temp.Grade}");
                temp = temp.Next;
            }
            
        }

        public void UpdateGrade()
        {
            Console.WriteLine("Enter the rollno ");
            int rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the grade to update");
            char grade = Console.ReadLine()[0];

            if (head == null)
            {
                Console.WriteLine("list is emplty");
                return;
            }

            Student temp = head;



            while(temp == null && temp.RollNumber != rollno)
            {
                temp = temp.Next;   
            }

            if (temp == null)
            {
                Console.WriteLine("Roll number is not present in the link list");
                return;
            }

            if(temp.RollNumber.Equals(rollno))
            {
                temp.Grade = grade;
                Console.WriteLine("Roll no is update");
            }

        }


        public void SwitchCase()
        {
            while (true)
            {
                
                Console.WriteLine(" 1.Add student at beginning \n 2.Add student at end \n 3.Add student at specific position \n 4.Delete the student \n 5.Search the student \n 6.Display All Student \n 7.update student grade\n 8. exits.");
                Console.WriteLine("Choose the operation");
                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        InsertAtBeginning();
                        break;
                    case 2:
                        InsertAtEnd();
                        break;
                    case 3:
                        InsertAtSpecific();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        SearchStudent();
                        break;
                    case 6:
                        DisplayStudent(); 
                        break;
                    case 7:
                        UpdateGrade();
                        break;
                    case 8:
                        return;

                    default:
                        Console.WriteLine("choose the correct operation");
                        break;
                }
            }


        }



    }
}
