using System;
using System.Collections.Generic;

namespace StudentExc2 {
    public class Cohort {
            public int name { get; set; }
        public List<Student> students = new List<Student>();
        public List<Instructor> instructors = new List<Instructor>();
    }
}