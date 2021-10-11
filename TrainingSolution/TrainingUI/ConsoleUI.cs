using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingModel;

namespace TrainingUI
{
    class MyConsultancy
    {
        Dictionary<int, Course> courseList;
        Dictionary<int, Training> trainingList;
        int courseCount = 0;

        public MyConsultancy()
        {
            courseList = new Dictionary<int, Course>();
            trainingList = new Dictionary<int, Training>();
        }
        public void AddCourse(string name)
        {
            courseList.Add(++courseCount, new Course(name));
        }
        public void AddTraining(string name, string hr, long cost)
        {
            trainingList.Add(trainingList.Count()+1, new Training(name, hr, cost));
        }        
        
        public void ShowCourses()
        {
            foreach( var course in courseList)
            {
                Console.WriteLine("\n***  " + course.Key + "\t:\t" + course.Value.Name + "\t\t:\t" + course.Value.Id);
            }
        }  
    }
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            MyConsultancy myConsultancy = new MyConsultancy();
            myConsultancy.AddCourse("Python Couse");
            myConsultancy.AddCourse("Full Stack");
            myConsultancy.AddCourse("Architecure Program");

            Console.WriteLine("*******Welcome********");
            myConsultancy.ShowCourses();
        }
    }
}
