using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */
            var courses = new List<Course>()
            {
                new Course { CourseId = 0, Name = "Psych 101", Students = new List<Student>()
                                                            {
                                                                new Student { StudentId = 0, Name = "Sean Goldsmith"},
                                                                new Student { StudentId = 1, Name = "Mary Skidmore"}
                                                            }
                            },
                new Course { CourseId = 1, Name = "Physics", Students= new List<Student>()
                                                            {
                                                                new Student { StudentId = 2, Name = "Pat Goldsmith"},
                                                                new Student { StudentId = 3, Name = "Karen Milarski"}
                                                            }
                            },
                new Course { CourseId = 2, Name = "Biology", Students = new List<Student>()
                {
                    new Student { StudentId = 4, Name = "Kevin Quattman"},
                    new Student { StudentId = 5, Name = "Pike Piccoli"}
                }

                            }
            };

            resultLabel.Text = "";
            foreach (Course course in courses)
            {
                resultLabel.Text += String.Format("Course: {0} - {1}<br><br>", course.CourseId, course.Name);
                foreach (Student student in course.Students)
                {
                    resultLabel.Text += String.Format("    Student: {0} - {1}<br>", student.StudentId, student.Name);
                }
                resultLabel.Text += "<br>";
            }

        }
  
            
        


        

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */
            var students = new Dictionary<int, Student>()
            {
                {0, new Student { StudentId = 0, Name = "Sean Goldsmith", Courses = new List<Course>()
                                                                        {
                                                                            new Course { CourseId = 0, Name = "Physics"},
                                                                            new Course { CourseId = 1, Name = "Biology"}
                                                                        }
                                }
                },
                {1, new Student { StudentId = 1, Name = "Mary Skidmore", Courses = new List<Course>()
                                                                        {
                                                                            new Course { CourseId = 2, Name = "Calculus"},
                                                                            new Course { CourseId = 3, Name = "World Religions"}
                                                                        }
                                }
                },
                {2, new Student { StudentId = 2, Name = "Kevin Quatman", Courses = new List<Course>()
                                                                        {
                                                                            new Course { CourseId = 2, Name = "Calculus"},
                                                                            new Course { CourseId = 1, Name = "Biology"}
                                                                        }
                                }
                }
            };

            resultLabel.Text = "";
            foreach (Student student in students.Values)
            {
                resultLabel.Text += String.Format("Student: {0} - {1}<br><br>",student.StudentId,student.Name);
                foreach (Course course in student.Courses)
                {
                    resultLabel.Text += String.Format("Course: {0} - {1}<br>", course.CourseId, course.Name);
                }
                resultLabel.Text += "<br>";
            }


        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */
            var students = new Dictionary<int, Student>()
            {
                {0, new Student { StudentId = 0, Name = "Sean Goldsmith", Courses = new List<Course>()
                                                                        {
                                                                            new Course { CourseId = 0, Name = "Physics"},
                                                                            new Course { CourseId = 1, Name = "Biology"}
                                                                        }
                                }
                },
                {1, new Student { StudentId = 1, Name = "Mary Skidmore", Courses = new List<Course>()
                                                                        {
                                                                            new Course { CourseId = 2, Name = "Calculus"},
                                                                            new Course { CourseId = 3, Name = "World Religions"}
                                                                        }
                                }
                },
                {2, new Student { StudentId = 2, Name = "Kevin Quatman", Courses = new List<Course>()
                                                                        {
                                                                            new Course { CourseId = 2, Name = "Calculus"},
                                                                            new Course { CourseId = 1, Name = "Biology"}
                                                                        }
                                }
                }
            };
            students[0].Grades = new Dictionary<int, Grade>()
            {
                {0, new Grade {classId = 0, grade = 95} },
                {1, new Grade { classId = 1, grade = 78} }
            };
            students[1].Grades = new Dictionary<int, Grade>()
            {
                {2, new Grade { classId = 2, grade = 98} },
                {3, new Grade { classId = 3, grade = 99} }
            };
            students[2].Grades = new Dictionary<int, Grade>()
            {
                {2, new Grade { classId = 2, grade = 55} },
                {1, new Grade { classId = 1, grade = 75} }
            };

            resultLabel.Text = "";
            foreach (Student student in students.Values)
            {
                resultLabel.Text += String.Format("Student: {0} - {1}<br><br>", student.StudentId, student.Name);
                foreach (Course course in student.Courses)
                {
                    resultLabel.Text += String.Format("Course: {0} - {1} - Grade {2}<br>", course.CourseId, course.Name,student.Grades[course.CourseId].grade);
                }
                resultLabel.Text += "<br><br>";
            }

        }
    }
}