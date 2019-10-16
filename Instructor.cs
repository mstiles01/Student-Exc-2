using System;
using System.Collections.Generic;

namespace StudentExc2
{
    public class Instructor
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public int cohort { get; set; }
       public string speciality {get; set;}

         public void assignStudents(Student student, Exercise exercise)
        {
            student.exercises.Add(exercise);
        }

    }

    }