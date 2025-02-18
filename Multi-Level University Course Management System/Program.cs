using System;
using System.Collections.Generic;
using Multi_Level_University_Course_Management_System;
class Program
{
    static void Main()
    {
        // Managing Exam-based courses
        Course<ExamCourse> examCourseStorage = new Course<ExamCourse>();
        examCourseStorage.AddCourse(new ExamCourse("Mathematics", "Dr. Smith", 120));
        examCourseStorage.AddCourse(new ExamCourse("Physics", "Prof. Johnson", 90));

        // Managing Assignment-based courses
        Course<AssignmentCourse> assignmentCourseStorage = new Course<AssignmentCourse>();
        assignmentCourseStorage.AddCourse(new AssignmentCourse("Programming", "Ms. Davis", 5));
        assignmentCourseStorage.AddCourse(new AssignmentCourse("History", "Mr. Brown", 3));

        // Display Courses
        examCourseStorage.DisplayAllCourses();
        assignmentCourseStorage.DisplayAllCourses();
    }
}
