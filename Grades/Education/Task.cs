using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Education
{
    class Task
    {
        public string Name { get; set; }
        public float Score { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public DateTime Createdate { get; private set; }
       
        public Task(string name, float score, int courseID, int studentID)
        {
            Name = name;
            Score = score;
            CourseID = courseID;
            StudentID = studentID;
            Createdate = DateTime.Now;            
        }
    }
}
